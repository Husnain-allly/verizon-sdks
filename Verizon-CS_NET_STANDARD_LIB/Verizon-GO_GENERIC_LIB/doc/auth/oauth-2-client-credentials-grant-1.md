
# OAuth 2 Client Credentials Grant



Documentation for accessing and setting credentials for thingspace_oauth1.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| oauthClientId | `string` | OAuth 2 Client ID | `WithOauthClientId` | `OauthClientId()` |
| oauthClientSecret | `string` | OAuth 2 Client Secret | `WithOauthClientSecret` | `OauthClientSecret()` |
| oauthToken | `OauthToken` | Object for storing information about the OAuth token | `WithOauthToken` | `OauthToken()` |
| OAuthTokenProvider | `func (models.OauthToken, ThingspaceOauth1Manager) models.OauthToken` | Registers a callback function for oAuth Token Provider used for automatic token fetching/refreshing | `WithOauthTokenProvider` | `OauthTokenProvider` |
| OAuthOnTokenUpdate | `func (token models.OauthToken)` | Registers a callback function for token update event | `WithOauthOnTokenUpdate` | `OauthOnTokenUpdate` |
| OAuthClockSkew | `int64` | Clock skew time in seconds applied while checking the OAuth Token expiry | `WithOauthClockSkew` | `OauthClockSkew` |



**Note:** Required auth credentials can be set using `WithThingspaceOauth1Credentials()` by providing a credentials instance with `NewThingspaceOauth1Credentials()` in the configuration initialization and accessed using the `ThingspaceOauth1Credentials()` method in the configuration instance.

## Usage Example

### Client Initialization

You must initialize the client with *OAuth 2.0 Client Credentials Grant* credentials as shown in the following code snippet. This will fetch the OAuth token automatically when any of the endpoints, requiring *OAuth 2.0 Client Credentials Grant* authentication, are called.

```go
client := verizon.NewClient(
    verizon.CreateConfiguration(
        verizon.WithThingspaceOauth1Credentials(
            verizon.NewThingspaceOauth1Credentials(
                "OAuthClientId",
                "OAuthClientSecret",
            ),
        ),
    ),
)
```



Your application can also manually provide an OAuthToken using the setter `WithOauthToken` in `ThingspaceOauth1Credentials` object. This function takes in an instance of OAuthToken containing information for authorizing client requests and refreshing the token itself.

### Adding OAuth Token Update Callback

Whenever the OAuth Token gets updated, the provided callback implementation will be executed. For instance, you may use it to store your access token whenever it gets updated.

```go
client := verizon.NewClient(
    verizon.CreateConfiguration(
        verizon.WithThingspaceOauth1Credentials(
            verizon.NewThingspaceOauth1Credentials(
                "OAuthClientId",
                "OAuthClientSecret",
            ).
            WithOauthOnTokenUpdate(func(oAuthToken models.OauthToken) {
                // Add the callback handler to perform operations like save to DB or file etc.
                // It will be triggered whenever the token gets updated
                saveTokenToDatabase(oAuthToken)
            }),
        ),
    ),
)
```

### Adding Custom OAuth Token Provider

To authorize a client using a stored access token, set up the `OauthTokenProvider` in `ThingspaceOauth1Credentials` builder along with the other auth parameters before creating the client:

```go
client := verizon.NewClient(
    verizon.CreateConfiguration(
        verizon.WithThingspaceOauth1Credentials(
            verizon.NewThingspaceOauth1Credentials(
                "OAuthClientId",
                "OAuthClientSecret",
            ).
            WithOauthTokenProvider(func(lastOAuthToken models.OauthToken, authManager ThingspaceOauth1Manager) models.OauthToken {
                // Add the callback function handler to provide a new OAuth token
                // It will be triggered whenever the lastOAuthToken is undefined or expired
                oAuthToken := loadTokenFromDatabase()
                if oAuthToken.AccessToken == "" {
                    if token, err := authManager.FetchToken(context.TODO()); err == nil {
                        return token
                    }
                }
                return oAuthToken
            }),
        ),
    ),
)
```


