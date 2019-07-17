// The file contents for the current environment will overwrite these during build.
// The build system defaults to the dev environment which uses `environment.ts`, but if you do
// `ng build --env=prod` then `environment.prod.ts` will be used instead.
// The list of which env maps to which file can be found in `.angular-cli.json`.

export const environment = {
  production: false,
  baseurl: 'http://localhost:53956/api',
  // baseurl: 'https://ptapi20190613040346.azurewebsites.net/api',
  defaultimageUrl: '/assets/images/users/defaultprofileimage.png',

  AccountOwner: 'AccountOwner',
  ResourceOnly: 'ResourceOnly',
  SuperAdmin: 'SuperAdmin',
  Admin: 'Admin',
  ProjectManager: 'ProjectManager',
  SeniorProjectManager: 'SeniorProjectManager',
  PortfolioAdmin: 'PortfolioAdmin',
  FinanceAdmin: 'FinanceAdmin',
  FinanceManager: 'FinanceManager',
  ReadOnly: 'ReadOnly',
  ReadWriteTimesheetOnly: 'ReadWriteTimesheetOnly',
};
