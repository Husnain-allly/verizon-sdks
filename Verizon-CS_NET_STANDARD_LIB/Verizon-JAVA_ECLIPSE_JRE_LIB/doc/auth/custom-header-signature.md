
# Custom Header Signature



Documentation for accessing and setting credentials for VZ-M2M-Token.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| VZ-M2M-Token | `String` | M2M Session Token ([How to generate an M2M session token?](../../doc/controllers/session-management.md#start-connectivity-management-session)) | `vzM2MToken` | `getVzM2MToken()` |



**Note:** Auth credentials can be set using `vzM2MTokenCredentials` in the client builder and accessed through `getVzM2MTokenCredentials` method in the client instance.

## Usage Example

### Client Initialization

You must provide credentials in the client as shown in the following code snippet.

```java
VerizonClient client = new VerizonClient.Builder()
    .vzM2MTokenCredentials(new VzM2MTokenModel.Builder(
            "VZ-M2M-Token"
        )
        .build())
    .build();
```


