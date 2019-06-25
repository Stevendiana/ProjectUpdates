import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MyprojectsComponent } from './myprojects.component';

const routes: Routes = [
  {
    path: '',
     component: MyprojectsComponent,
    data: {
      title: 'My Projects'
    },

  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MyprojectsRoutingModule { }
export const routedComponents = [MyprojectsComponent];
