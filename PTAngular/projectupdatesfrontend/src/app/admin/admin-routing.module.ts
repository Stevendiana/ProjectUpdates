import { HierarchyComponent } from './hierarchy/hierarchy.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ResourceComponent } from '../resources/resource/resource.component';
import { UploadCentreComponent } from './upload-centre/upload-centre.component';


const routes: Routes = [
  {
    path: '',
    children: [
      {
        path: 'hierarchy',
        component: HierarchyComponent,
        data: {
          title: 'Project Hierarchy'
        }
      },
      {
        path: 'resource',
        component: ResourceComponent,
        data: {
          title: 'Resource'
        }
      },
      {
        path: 'uploadcentre',
        component: UploadCentreComponent,
        data: {
          title: 'Upload Centre'
        }
      },
    ]
    // path: '',
    //  component: MyprojectsComponent,
    // data: {
    //   title: 'Projects'
    // },

  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
// export const routedComponents = [MyprojectsComponent];
