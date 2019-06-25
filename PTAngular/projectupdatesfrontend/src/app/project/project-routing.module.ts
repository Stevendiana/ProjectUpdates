import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProjectComponent } from './project/project.component';

const routes: Routes = [
  {
    path: '',
     component: ProjectComponent,
    data: {
      title: 'Project'
    },

  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProjectRoutingModule { }
export const routedComponents = [ProjectComponent];
