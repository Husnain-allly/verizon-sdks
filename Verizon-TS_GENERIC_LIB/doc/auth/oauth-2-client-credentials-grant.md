
# OAuth 2 Client Credentials Grant



Documentation for accessing and setting credentials for thingspace_oauth.

## Auth Credentials

| Name | Type | Description | Setter |
|  --- | --- | --- | --- |
| OAuthClientId | `string` | OAuth 2 Client ID | `oauthClientId` |
| OAuthClientSecret | `string` | OAuth 2 Client Secret | `oauthClientSecret` |
| OAuthToken | `OauthToken` | Object for storing information about the OAuth token | `oauthToken` |
| OAuthScopes | `OauthScopeThingspaceOauth[]` | List of scopes that apply to the OAuth token | `oauthScopes` |
| OAuthClockSkew | `number` | Clock skew time in seconds applied while checking the OAuth Token expiry. | `clockSkew` |
| OAuthTokenProvider | `(lastOAuthToken: OauthToken \| undefined, authManager: ThingspaceOauthManager) => Promise<OauthToken>` | Registers a callback for oAuth Token Provider used for automatic token fetching/refreshing. | `oauthTokenProvider` |
| OAuthOnTokenUpdate | `(token: OauthToken) => void` | Registers a callback for token update event. | `oauthOnTokenUpdate` |



**Note:** Auth credentials can be set using `thingspaceOauthCredentials` object in the client.

## Usage Example

### Client Initialization

You must initialize the client with *OAuth 2.0 Client Credentials Grant* credentials as shown in the following code snippet. This will fetch the OAuth token automatically when any of the endpoints, requiring *OAuth 2.0 Client Credentials Grant* authentication, are called.

```ts
const client = new Client({
  thingspaceOauthCredentials: {
    oauthClientId: 'OAuthClientId',
    oauthClientSecret: 'OAuthClientSecret',
    oauthScopes: [
      OauthScopeThingspaceOauth.Discoveryread,
      OauthScopeThingspaceOauth.Serviceprofileread
    ]
  },
});
```



Your application can also manually provide an OAuthToken using the setter `oauthToken` in `thingspaceOauthCredentials` object. This function takes in an instance of OAuthToken containing information for authorizing client requests and refreshing the token itself.

You must have initialized the client with scopes for which you need permission to access.

### Scopes

Scopes enable your application to only request access to the resources it needs while enabling users to control the amount of access they grant to your application. Available scopes are defined in the [`OauthScopeThingspaceOauth`](../../doc/models/oauth-scope-thingspace-oauth.md) enumeration.

| Scope Name | Description |
|  --- | --- |
| `Discoveryread` | Grant read-only access to discovery data |
| `Serviceprofileread` | Grant read-only access to service profile data |
| `Serviceprofilewrite` | Grant write access to service profile data |
| `Serviceregistryread` | Grant read-only access to Service registry data |
| `Serviceregistrywrite` | Grant write access to Service registry data |
| `TsMecFullaccess` | Full access for /serviceprofiles and /serviceendpoints. |
| `TsMecLimitaccess` | Limited access. Will not allow use of /serviceprofiles and /serviceendpoints but will allow discovery. |
| `TsApplicationRo` |  |
| `Edgediscoveryread` | Read access to the discovery service |
| `Edgeserviceprofileread` | Read access to the service profile service |
| `Edgeserviceprofilewrite` | Write access to the service profile service |
| `Edgeserviceregistryread` | Read access to the service registry service |
| `Edgeserviceregistrywrite` | Write access to the service registry service |
| `Read` | read access |
| `Write` | read/write access |

### Adding OAuth Token Update Callback

Whenever the OAuth Token gets updated, the provided callback implementation will be executed. For instance, you may use it to store your access token whenever it gets updated.

```ts
const client = new Client({
  thingspaceOauthCredentials: {
    oauthClientId: 'OAuthClientId',
    oauthClientSecret: 'OAuthClientSecret',
    oauthScopes: [
      OauthScopeThingspaceOauth.Discoveryread,
      OauthScopeThingspaceOauth.Serviceprofileread
    ],
    oauthOnTokenUpdate: (token: OauthToken) => {
      // Add the callback handler to perform operations like save to DB or file etc.
      // It will be triggered whenever the token gets updated
      saveTokenToDatabase(token);
    }
  },
});
```

### Adding Custom OAuth Token Provider

To authorize a client using a stored access token, set up the `oauthTokenProvider` in `thingspaceOauthCredentials` along with the other auth parameters before creating the client:

```ts
const client = new Client({
  thingspaceOauthCredentials: {
    oauthClientId: 'OAuthClientId',
    oauthClientSecret: 'OAuthClientSecret',
    oauthScopes: [
      OauthScopeThingspaceOauth.Discoveryread,
      OauthScopeThingspaceOauth.Serviceprofileread
    ],
    oauthTokenProvider: (lastOAuthToken: OauthToken | undefined, authManager: ThingspaceOauthManager) => {
      // Add the callback handler to provide a new OAuth token
      // It will be triggered whenever the lastOAuthToken is undefined or expired
      return loadTokenFromDatabase() ?? authManager.fetchToken();
    }
  },
});
```


