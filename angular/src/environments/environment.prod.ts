import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'TeduEcomerce',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44397/',
    redirectUri: baseUrl,
    clientId: 'TeduEcomerce_App',
    responseType: 'code',
    scope: 'offline_access TeduEcomerce',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44373',
      rootNamespace: 'TeduEcomerce',
    },
  },
} as Environment;
