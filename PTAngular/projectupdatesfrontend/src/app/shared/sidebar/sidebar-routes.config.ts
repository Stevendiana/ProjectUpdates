import { RouteInfo } from './sidebar.metadata';

//Sidebar menu Routes and data
export const ROUTES: RouteInfo[] = [

    // {
    //     path: '', title: 'Dashboard', icon: 'ft-home', class: 'has-sub', badge: '2', badgeClass: 'badge badge-pill badge-danger float-right mr-1 mt-1', isExternalLink: false, submenu: [
    //         { path: '/dashboard/dashboard1', title: 'Dashboard1', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    //         { path: '/dashboard/dashboard2', title: 'Dashboard2', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    //     ]
    // },
    { path: '/myprojects/myprojects', title: 'My projects', icon: 'ft-home', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },

    { path: '', title: 'Resource Pool', icon: 'ft-droplet', class: 'has-sub', badge: '', badgeClass: '', isExternalLink: false,
    submenu: [
      { path: '/resources/dashboard', title: 'Dashboard', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
      { path: '/resources/resources', title: 'Resources', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
      { path: '/resources/demand', title: 'Demand', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
      { path: '/resources/availability', title: 'Availability', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
      { path: '/resources/utilization', title: 'Utilization', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    ] },
    { path: '/timesheets', title: 'My timesheets', icon: 'ft-droplet', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    { path: '/project', title: 'Project', icon: 'ft-droplet', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    // { path: '/colorpalettes', title: 'Color Palette', icon: 'ft-droplet', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    { path: '/inbox', title: 'Inbox', icon: 'ft-mail', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    { path: '/chat', title: 'Chat', icon: 'ft-message-square', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    { path: '/support', title: '"How to" guide', icon: 'ft-message-square', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },

    {
        path: '', title: 'Admin', icon: 'ft-copy', class: 'has-sub', badge: '', badgeClass: '', isExternalLink: false,
        submenu: [
            { path: '/admin/hierarchy', title: 'Project Hierarchy', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
            { path: '/admin/resource', title: 'Resource Centre', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
            { path: '/admin/uploadcentre', title: 'Upload Centre', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
            // { path: '/support/howtoguide', title: '"How to" guide', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },

        ]
    },
    // {
    //     path: '', title: 'Pages', icon: 'ft-copy', class: 'has-sub', badge: '', badgeClass: '', isExternalLink: false,
    //     submenu: [
    //         { path: '/pages/forgotpassword', title: 'Forgot Password', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    //         { path: '/pages/horizontaltimeline', title: 'Horizontal Timeline', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    //         { path: '/pages/verticaltimeline', title: 'Vertical Timeline', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    //         { path: '/pages/login', title: 'Login', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    //         { path: '/pages/register', title: 'Register', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    //         { path: '/pages/profile', title: 'User Profile', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    //         { path: '/pages/lockscreen', title: 'Lock Screen', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    //         { path: '/pages/invoice', title: 'Invoice', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    //         { path: '/pages/error', title: 'Error', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    //         { path: '/pages/comingsoon', title: 'Coming Soon', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    //         { path: '/pages/maintenance', title: 'Maintenance', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    //         { path: '/pages/gallery', title: 'Gallery', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    //         { path: '/pages/search', title: 'Search', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    //         { path: '/pages/faq', title: 'FAQ', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    //         { path: '/pages/kb', title: 'Knowledge Base', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    //     ]
    // },
    // { path: 'https://pixinvent.com/apex-angular-4-bootstrap-admin-template/documentation', title: 'Documentation', icon: 'ft-book', class: '', badge: '', badgeClass: '', isExternalLink: true, submenu: [] },
    // { path: 'https://pixinvent.ticksy.com/', title: 'Support', icon: 'ft-life-buoy', class: '', badge: '', badgeClass: '', isExternalLink: true, submenu: [] },
];
