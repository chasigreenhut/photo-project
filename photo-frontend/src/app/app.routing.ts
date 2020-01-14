import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home';
import { LoginComponent } from './login';
import { RegisterComponent } from './register';
import { AuthGuard } from './_guards';
import { StartComponent } from './start/start.component';
import { AdminHomeComponent } from './admin-home/admin-home.component';
import { OrdersComponent } from './orders/orders.component';

const appRoutes: Routes = [
    { path: '', component: StartComponent, canActivate: [AuthGuard] },
    { path: 'home', component: HomeComponent },
    { path: 'admin-home', component: AdminHomeComponent },
    { path: 'start', component: StartComponent },
    { path: 'login', component: LoginComponent },
    { path: 'register', component: RegisterComponent },
    { path: 'orders', component: OrdersComponent },


    // otherwise redirect to home
    { path: '**', redirectTo: '' }
];

export const routing = RouterModule.forRoot(appRoutes);