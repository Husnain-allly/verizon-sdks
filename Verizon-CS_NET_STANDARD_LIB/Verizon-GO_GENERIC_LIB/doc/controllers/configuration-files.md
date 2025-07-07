# Configuration Files

```go
configurationFilesApi := client.ConfigurationFilesApi()
```

## Class Name

`ConfigurationFilesApi`

## Methods

* [Get List of Files](../../doc/controllers/configuration-files.md#get-list-of-files)
* [Upload Config File](../../doc/controllers/configuration-files.md#upload-config-file)


# Get List of Files

You can retrieve a list of configuration or supplementary of files for an account.

```go
GetListOfFiles(
    ctx context.Context,
    acc string,
    distributionType string) (
    models.ApiResponse[models.RetrievesAvailableFilesResponseList],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `distributionType` | `string` | Query, Required | Filter the distributionType to only retrieve files for a specific distribution type. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.RetrievesAvailableFilesResponseList](../../doc/models/retrieves-available-files-response-list.md).

## Example Usage

```go
ctx := context.Background()

acc := "0402196254-00001"

distributionType := "HTTP"

apiResponse, err := configurationFilesApi.GetListOfFiles(ctx, acc, distributionType)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Upload Config File

Uploads a configuration/supplementary file for an account. ThingSpace generates a fileName after the upload and is returned in the response.

```go
UploadConfigFile(
    ctx context.Context,
    acc string,
    fileupload *models.FileWrapper,
    fileVersion *string,
    make *string,
    model *string,
    localTargetPath *string) (
    models.ApiResponse[models.UploadConfigurationFilesResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `fileupload` | `*models.FileWrapper` | Form, Optional | The file to upload. |
| `fileVersion` | `*string` | Form, Optional | Version of the file. |
| `make` | `*string` | Form, Optional | The software-applicable device make. |
| `model` | `*string` | Form, Optional | The software-applicable device model. |
| `localTargetPath` | `*string` | Form, Optional | Local target path on the device. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.UploadConfigurationFilesResponse](../../doc/models/upload-configuration-files-response.md).

## Example Usage

```go
ctx := context.Background()

acc := "0402196254-00001"



fileVersion := "1.0"

make := "Verizon"

model := "VZW1"

localTargetPath := "/VZWFOTA/hello-world.txt"

apiResponse, err := configurationFilesApi.UploadConfigFile(ctx, acc, nil, &fileVersion, &make, &model, &localTargetPath)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

