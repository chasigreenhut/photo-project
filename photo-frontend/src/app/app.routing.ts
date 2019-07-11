import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home';
import { LoginComponent } from './login';
import { RegisterComponent } from './register';
import { AuthGuard } from './_guards';
import { StartComponent } from './start/start.component';

const appRoutes: Routes = [
    { path: '', component: StartComponent, canActivate: [AuthGuard] },
    { path: 'home', component: HomeComponent },
    { path: 'start', component: StartComponent },
    { path: 'login', component: LoginComponent },
    { path: 'register', component: RegisterComponent },

    // otherwise redirect to home
    { path: '**', redirectTo: '' }
];

export const routing = RouterModule.forRoot(appRoutes);