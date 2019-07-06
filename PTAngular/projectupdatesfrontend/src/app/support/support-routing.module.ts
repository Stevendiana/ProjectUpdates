import { SupportHowToDoGuideComponent } from './support-how-to-do-guide/support-how-to-do-guide.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    children: [
      {
        path: '',
        component: SupportHowToDoGuideComponent,
        data: {
          title: '"How to" guide'
        },
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
export class SupportRoutingModule { }
export const routedComponents = [SupportHowToDoGuideComponent];
