import { Routes, RouterModule } from '@angular/router';

// Route for content layout with sidebar, navbar and footer.

export const Full_ROUTES: Routes = [
  {
    path: 'dashboard',
    loadChildren: './dashboard/dashboard.module#DashboardModule'
  },
  {
    path: 'pages',
    loadChildren: './pages/full-pages/full-pages.module#FullPagesModule'
  },
  {
    path: 'project',
    loadChildren: './project/project.module#ProjectModule'
  },
  {
    path: 'resources',
    loadChildren: './resources/resources.module#ResourcesModule'
  },
  {
    path: 'myprojects',
    loadChildren: './myprojects/myprojects.module#MyprojectsModule'
  },
  {
    path: 'chat',
    loadChildren: './chat/chat.module#ChatModule'
  },
  {
    path: 'inbox',
    loadChildren: './inbox/inbox.module#InboxModule'
  },
  {
    path: 'timesheets',
    loadChildren: './timesheets/timesheets.module#TimesheetsModule'
  },
];
