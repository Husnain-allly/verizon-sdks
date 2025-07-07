
# OAuth 2 Client Credentials Grant



Documentation for accessing and setting credentials for thingspace_oauth.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| oauthClientId | `string` | OAuth 2 Client ID | `WithOauthClientId` | `OauthClientId()` |
| oauthClientSecret | `string` | OAuth 2 Client Secret | `WithOauthClientSecret` | `OauthClientSecret()` |
| oauthToken | `OauthToken` | Object for storing information about the OAuth token | `WithOauthToken` | `OauthToken()` |
| oauthScopes | `[]OauthScopeThingspaceOauth` | List of scopes that apply to the OAuth token | `WithOauthScopes` | `OauthScopes()` |
| OAuthTokenProvider | `func (models.OauthToken, ThingspaceOauthManager) models.OauthToken` | Registers a callback function for oAuth Token Provider used for automatic token fetching/refreshing | `WithOauthTokenProvider` | `OauthTokenProvider` |
| OAuthOnTokenUpdate | `func (token models.OauthToken)` | Registers a callback function for token update event | `WithOauthOnTokenUpdate` | `OauthOnTokenUpdate` |
| OAuthClockSkew | `int64` | Clock skew time in seconds applied while checking the OAuth Token expiry | `WithOauthClockSkew` | `OauthClockSkew` |



**Note:** Required auth credentials can be set using `WithThingspaceOauthCredentials()` by providing a credentials instance with `NewThingspaceOauthCredentials()` in the configuration initialization and accessed using the `ThingspaceOauthCredentials()` method in the configuration instance.

## Usage Example

### Client Initialization

You must initialize the client with *OAuth 2.0 Client Credentials Grant* credentials as shown in the following code snippet. This will fetch the OAuth token automatically when any of the endpoints, requiring *OAuth 2.0 Client Credentials Grant* authentication, are called.

```go
client := verizon.NewClient(
    verizon.CreateConfiguration(
        verizon.WithThingspaceOauthCredentials(
            verizon.NewThingspaceOauthCredentials(
                "OAuthClientId",
                "OAuthClientSecret",
            ).
            WithOauthScopes([]models.OauthScopeThingspaceOauth{
        models.OauthScopeThingspaceOauth_Discoveryread,
        models.OauthScopeThingspaceOauth_Serviceprofileread,
    }),
        ),
    ),
)
```



Your application can also manually provide an OAuthToken using the setter `WithOauthToken` in `ThingspaceOauthCredentials` object. This function takes in an instance of OAuthToken containing information for authorizing client requests and refreshing the token itself.

You must have initialized the client with scopes for which you need permission to access.

### Scopes

Scopes enable your application to only request access to the resources it needs while enabling users to control the amount of access they grant to your application. Available scopes are defined in the [`OauthScopeThingspaceOauth`](../../doc/models/oauth-scope-thingspace-oauth.md) enumeration.

| Scope Name | Description |
|  --- | --- |
| `DISCOVERYREAD` | Grant read-only access to discovery data |
| `SERVICEPROFILEREAD` | Grant read-only access to service profile data |
| `SERVICEPROFILEWRITE` | Grant write access to service profile data |
| `SERVICEREGISTRYREAD` | Grant read-only access to Service registry data |
| `SERVICEREGISTRYWRITE` | Grant write access to Service registry data |
| `TS_MEC_FULLACCESS` | Full access for /serviceprofiles and /serviceendpoints. |
| `TS_MEC_LIMITACCESS` | Limited access. Will not allow use of /serviceprofiles and /serviceendpoints but will allow discovery. |
| `TS_APPLICATION_RO` |  |
| `EDGEDISCOVERYREAD` | Read access to the discovery service |
| `EDGESERVICEPROFILEREAD` | Read access to the service profile service |
| `EDGESERVICEPROFILEWRITE` | Write access to the service profile service |
| `EDGESERVICEREGISTRYREAD` | Read access to the service registry service |
| `EDGESERVICEREGISTRYWRITE` | Write access to the service registry service |
| `READ` | read access |
| `WRITE` | read/write access |

### Adding OAuth Token Update Callback

Whenever the OAuth Token gets updated, the provided callback implementation will be executed. For instance, you may use it to store your access token whenever it gets updated.

```go
client := verizon.NewClient(
    verizon.CreateConfiguration(
        verizon.WithThingspaceOauthCredentials(
            verizon.NewThingspaceOauthCredentials(
                "OAuthClientId",
                "OAuthClientSecret",
            ).
            WithOauthOnTokenUpdate(func(oAuthToken models.OauthToken) {
                // Add the callback handler to perform operations like save to DB or file etc.
                // It will be triggered whenever the token gets updated
                saveTokenToDatabase(oAuthToken)
            }).
            WithOauthScopes([]models.OauthScopeThingspaceOauth{
        models.OauthScopeThingspaceOauth_Discoveryread,
        models.OauthScopeThingspaceOauth_Serviceprofileread,
    }),
        ),
    ),
)
```

### Adding Custom OAuth Token Provider

To authorize a client using a stored access token, set up the `OauthTokenProvider` in `ThingspaceOauthCredentials` builder along with the other auth parameters before creating the client:

```go
client := verizon.NewClient(
    verizon.CreateConfiguration(
        verizon.WithThingspaceOauthCredentials(
            verizon.NewThingspaceOauthCredentials(
                "OAuthClientId",
                "OAuthClientSecret",
            ).
            WithOauthTokenProvider(func(lastOAuthToken models.OauthToken, authManager ThingspaceOauthManager) models.OauthToken {
                // Add the callback function handler to provide a new OAuth token
                // It will be triggered whenever the lastOAuthToken is undefined or expired
                oAuthToken := loadTokenFromDatabase()
                if oAuthToken.AccessToken == "" {
                    if token, err := authManager.FetchToken(context.TODO()); err == nil {
                        return token
                    }
                }
                return oAuthToken
            }).
            WithOauthScopes([]models.OauthScopeThingspaceOauth{
        models.OauthScopeThingspaceOauth_Discoveryread,
        models.OauthScopeThingspaceOauth_Serviceprofileread,
    }),
        ),
    ),
)
```


