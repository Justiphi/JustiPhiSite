import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { About } from './pages/about/about';
import { Contact } from './pages/contact/contact';
import { Home } from './pages/home/home';
import { Services } from './pages/services/services';

const routes: Routes = [
  { path: '', component: Home, title: 'JustiPhi Technologies | 3D Printing, IT Support & Software' },
  { path: 'services', component: Services, title: 'Services | JustiPhi Technologies' },
  { path: 'about', component: About, title: 'About | JustiPhi Technologies' },
  { path: 'contact', component: Contact, title: 'Contact | JustiPhi Technologies' },
  { path: '**', redirectTo: '' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { scrollPositionRestoration: 'enabled', anchorScrolling: 'enabled' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
