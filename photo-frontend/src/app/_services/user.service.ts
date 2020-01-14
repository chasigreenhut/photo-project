import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { User } from '../_models';
import { environment } from 'src/environments/environment';
import { Order } from '../_models/order';

@Injectable({ providedIn: 'root' })
export class UserService {

    // private baseUrl="http://localhost:54225";
    constructor(private http: HttpClient) { }
    getAll() {
        // return this.http.get(this.baseUrl+'/api/Account/Users');
        return this.http.get<User[]>(`${environment.apiUrl}/api/Account/Users`);
    }
    getAllOrdersById(id:number) {

        return this.http.get<Order[]>(`${environment.apiUrl}/api/Account/getOrderByUser?idUser=`+id);
    }

    getById(id: number) {
        return this.http.get(`${environment.apiUrl}/users/${id}`);
    }

    register(user: User) {
        return this.http.post(`${environment.apiUrl}/api/Account/Register`, user);
    }

    update(user: User) {
        return this.http.put(`${environment.apiUrl}/users/${user.userId}`, user);
    }

    delete(id: number) {
        return this.http.delete(`${environment.apiUrl}/Users/${id}`);
    }
}