import { Component, OnInit, OnDestroy } from '@angular/core';
import { Subscription, from } from 'rxjs';
import { first } from 'rxjs/operators';

import { User } from '../_models';
import { UserService, AuthenticationService } from '../_services';
import { OrderService } from '../_services/order.service';
import { Order, UserOrders } from '../_models/order';
import { ActivatedRoute, Router } from '@angular/router';
@Component({ templateUrl: 'admin-home.component.html' })
export class AdminHomeComponent implements OnInit, OnDestroy {
    currentUser: User;
    currentUserSubscription: Subscription;
    users: User[] = [];

    constructor(
        private authenticationService: AuthenticationService,
        private userService: UserService,
        private orderService: OrderService,
        private route: Router,
        private userOrders: UserOrders
    ) {

        this.currentUserSubscription = this.authenticationService.currentUser.subscribe(user => {
            this.currentUser = user;
        });
    }

    ngOnInit() {
        this.loadAllUsers();
        // this.loadAllOrders();
    }

    ngOnDestroy() {
        // unsubscribe to ensure no memory leaks
        this.currentUserSubscription.unsubscribe();
    }

    deleteUser(id: number) {
        this.userService.delete(id).pipe(first()).subscribe(() => {
            this.loadAllUsers()
        });
    }

    private loadAllUsers() {
        this.userService.getAll().pipe(first())
            .subscribe(data => {
                this.users = data as User[];
            },
                error => {
                    console.log("error")
                });

    }
    getOrderByUser(id: number) {
        this.userService.getAllOrdersById(id).
            subscribe((data: any) => {
                this.userOrders.orders = data;
                if (this.userOrders.orders && this.userOrders.orders.length > 0) {
                    this.route.navigate(['orders']);
                }
            },
                error => {
                    console.log("error")
                });


    }
    private loadAllOrders() {
        this.orderService.getAll().subscribe(order => {
            this.userOrders.orders = order;
        });
    }
}