
# Custom Header Signature



Documentation for accessing and setting credentials for VZ-M2M-Token.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| vzM2MToken | `string` | M2M Session Token ([How to generate an M2M session token?](../../doc/controllers/session-management.md#start-connectivity-management-session)) | `WithVzM2MToken` | `VzM2MToken()` |



**Note:** Required auth credentials can be set using `WithVzM2MTokenCredentials()` by providing a credentials instance with `NewVzM2MTokenCredentials()` in the configuration initialization and accessed using the `VzM2MTokenCredentials()` method in the configuration instance.

## Usage Example

### Client Initialization

You must provide credentials in the client as shown in the following code snippet.

```go
client := verizon.NewClient(
    verizon.CreateConfiguration(
        verizon.WithVzM2MTokenCredentials(
            verizon.NewVzM2MTokenCredentials("VZ-M2M-Token"),
        ),
    ),
)
```


