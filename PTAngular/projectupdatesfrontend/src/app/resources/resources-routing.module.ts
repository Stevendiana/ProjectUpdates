import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ResourcesComponent } from './resources/resources.component';

const routes: Routes = [
  {
    path: '',
     component: ResourcesComponent,
    data: {
      title: 'Resource pool'
    },
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ResourcesRoutingModule { }
export const routedComponents = [ResourcesComponent];
