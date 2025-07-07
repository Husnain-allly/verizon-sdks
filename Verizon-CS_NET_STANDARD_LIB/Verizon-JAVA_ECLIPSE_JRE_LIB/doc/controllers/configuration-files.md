# Configuration Files

```java
ConfigurationFilesApi configurationFilesApi = client.getConfigurationFilesApi();
```

## Class Name

`ConfigurationFilesApi`

## Methods

* [Get List of Files](../../doc/controllers/configuration-files.md#get-list-of-files)
* [Upload Config File](../../doc/controllers/configuration-files.md#upload-config-file)


# Get List of Files

You can retrieve a list of configuration or supplementary of files for an account.

```java
CompletableFuture<ApiResponse<RetrievesAvailableFilesResponseList>> getListOfFilesAsync(
    final String acc,
    final String distributionType)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `String` | Template, Required | Account identifier. |
| `distributionType` | `String` | Query, Required | Filter the distributionType to only retrieve files for a specific distribution type. |

## Server

`Server.SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`RetrievesAvailableFilesResponseList`](../../doc/models/retrieves-available-files-response-list.md).

## Example Usage

```java
String acc = "0402196254-00001";
String distributionType = "HTTP";

configurationFilesApi.getListOfFilesAsync(acc, distributionType).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Upload Config File

Uploads a configuration/supplementary file for an account. ThingSpace generates a fileName after the upload and is returned in the response.

```java
CompletableFuture<ApiResponse<UploadConfigurationFilesResponse>> uploadConfigFileAsync(
    final String acc,
    final FileWrapper fileupload,
    final String fileVersion,
    final String make,
    final String model,
    final String localTargetPath)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `String` | Template, Required | Account identifier. |
| `fileupload` | `FileWrapper` | Form, Optional | The file to upload. |
| `fileVersion` | `String` | Form, Optional | Version of the file. |
| `make` | `String` | Form, Optional | The software-applicable device make. |
| `model` | `String` | Form, Optional | The software-applicable device model. |
| `localTargetPath` | `String` | Form, Optional | Local target path on the device. |

## Server

`Server.SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`UploadConfigurationFilesResponse`](../../doc/models/upload-configuration-files-response.md).

## Example Usage

```java
String acc = "0402196254-00001";
String fileVersion = "1.0";
String make = "Verizon";
String model = "VZW1";
String localTargetPath = "/VZWFOTA/hello-world.txt";

configurationFilesApi.uploadConfigFileAsync(acc, null, fileVersion, make, model, localTargetPath).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

