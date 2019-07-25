import { Component, OnInit, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs';
import { first } from 'rxjs/operators';

import { User } from '../_models';
import { UserService, AuthenticationService } from '../_services';
import { OrderService } from '../_services/order.service';
import { Order } from '../_models/order';

@Component({ templateUrl: 'admin-home.component.html' })
export class AdminHomeComponent implements OnInit, OnDestroy {
    currentUser: User;
    currentUserSubscription: Subscription;
    users: User[] = [];
    orders: Order[] = [];

    constructor(
        private authenticationService: AuthenticationService,
        private userService: UserService,
        private orderService:OrderService
    ) {
        
        this.currentUserSubscription = this.authenticationService.currentUser.subscribe(user => {
            this.currentUser = user;
        });
    }

    ngOnInit() {
        this.loadAllUsers();
        this.loadAllOrders();
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
        this.userService.getAll().pipe(first()).subscribe(users => {
            this.users = users;
        });
    }

    private loadAllOrders() {
        this.orderService.getAll().pipe(first()).subscribe(order => {
            this.orders = order;
        });
    }
}