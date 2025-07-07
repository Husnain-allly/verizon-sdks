
# OAuth 2 Client Credentials Grant



Documentation for accessing and setting credentials for thingspace_oauth1.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| OAuthClientId | `String` | OAuth 2 Client ID | `oauthClientId` | `getOauthClientId()` |
| OAuthClientSecret | `String` | OAuth 2 Client Secret | `oauthClientSecret` | `getOauthClientSecret()` |
| OAuthToken | `OauthToken` | Object for storing information about the OAuth token | `oauthToken` | `getOauthToken()` |
| OAuthClockSkew | `long` | Clock skew time in seconds applied while checking the OAuth Token expiry. | `oauthClockSkew` | `getOauthClockSkew()` |
| OAuthTokenProvider | `BiFunction<OAuthToken, ThingspaceOauth1Credentials, OAuthToken>` | Registers a callback for oAuth Token Provider used for automatic token fetching/refreshing. | `oauthTokenProvider` | `getOauthTokenProvider()` |
| OAuthOnTokenUpdate | `Consumer<OAuthToken>` | Registers a callback for token update event. | `oauthOnTokenUpdate` | `getOauthOnTokenUpdate()` |



**Note:** Auth credentials can be set using `thingspaceOauth1Credentials` in the client builder and accessed through `getThingspaceOauth1Credentials` method in the client instance.

## Usage Example

### Client Initialization

You must initialize the client with *OAuth 2.0 Client Credentials Grant* credentials as shown in the following code snippet. This will fetch the OAuth token automatically when any of the endpoints, requiring *OAuth 2.0 Client Credentials Grant* authentication, are called.

```java
VerizonClient client = new VerizonClient.Builder()
    .thingspaceOauth1Credentials(new ThingspaceOauth1Model.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .build())
    .build();
```



Your application can also manually provide an OAuthToken using the setter `oauthToken` in `ThingspaceOauth1Model` object. This function takes in an instance of OAuthToken containing information for authorizing client requests and refreshing the token itself.

### Adding OAuth Token Update Callback

Whenever the OAuth Token gets updated, the provided callback implementation will be executed. For instance, you may use it to store your access token whenever it gets updated.

```java
VerizonClient client = new VerizonClient.Builder()
    .thingspaceOauth1Credentials(new ThingspaceOauth1Model.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .oauthOnTokenUpdate(oAuthToken -> {
                // Add the callback handler to perform operations like save to DB or file etc.
                // It will be triggered whenever the token gets updated
                saveTokenToDatabase(oAuthToken);
        })
        .build())
    .build();
```

### Adding Custom OAuth Token Provider

To authorize a client using a stored access token, set up the `oauthTokenProvider` in `ThingspaceOauth1Model` builder along with the other auth parameters before creating the client:

```java
VerizonClient client = new VerizonClient.Builder()
    .thingspaceOauth1Credentials(new ThingspaceOauth1Model.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .oauthTokenProvider((lastOAuthToken, credentialsManager) -> {
                // Add the callback handler to provide a new OAuth token
                // It will be triggered whenever the lastOAuthToken is undefined or expired
                OauthToken oAuthToken = loadTokenFromDatabase();
                if (oAuthToken != null && !credentialsManager.isTokenExpired(oAuthToken)) {
                    return oAuthToken;
                }
                return credentialsManager.fetchToken();
        })
        .build())
    .build();
```


