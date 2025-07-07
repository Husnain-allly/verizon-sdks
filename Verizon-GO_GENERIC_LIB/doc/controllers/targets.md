# Targets

```go
targetsApi := client.TargetsApi()
```

## Class Name

`TargetsApi`

## Methods

* [Query Target](../../doc/controllers/targets.md#query-target)
* [Delete Target](../../doc/controllers/targets.md#delete-target)
* [Create Target](../../doc/controllers/targets.md#create-target)
* [Generate Target External ID](../../doc/controllers/targets.md#generate-target-external-id)
* [Create Azure Central Io T Application](../../doc/controllers/targets.md#create-azure-central-io-t-application)


# Query Target

Search for targets by property values. Returns an array of all matching target resources.

```go
QueryTarget(
    ctx context.Context,
    body models.QueryTargetRequest) (
    models.ApiResponse[[]models.Target],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.QueryTargetRequest`](../../doc/models/query-target-request.md) | Body, Required | Search for targets by property values. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.Target](../../doc/models/target.md).

## Example Usage

```go
ctx := context.Background()

body := models.QueryTargetRequest{
    Accountidentifier:     models.ToPointer(models.AccountIdentifier{
        Billingaccountid:      models.ToPointer("1223334444-00001"),
    }),
    Resourceidentifier:    models.ToPointer(models.ResourceIdentifier{
        Id:                    models.ToPointer("dd1682d3-2d80-cefc-f3ee-25154800beff"),
    }),
}

apiResponse, err := targetsApi.QueryTarget(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
[
  {
    "address": "https://myhost.com:1825",
    "addressscheme": "streamrest",
    "createdon": "2018-12-22T03:59:18.563Z",
    "id": "cee10900-f54e-6eef-e455-bd7f15c4be32",
    "kind": "ts.target",
    "lastupdated": "2018-12-22T03:59:18.563Z",
    "name": "host:port target",
    "version": "1.0",
    "versionid": "f4be7c2b-059d-11e9-bec6-02420a4e1b0a"
  },
  {
    "address": "arn:aws:iam::252156542789:role/ThingSpace",
    "addressscheme": "streamawsiot",
    "createdon": "2019-01-24T19:06:43.577Z",
    "externalid": "lJZnih8BfqsosZrEEkfPuR3aGOk2i-HIr6tXN275ioJF6bezIrQB9EbzpTRep8J7RmV7QH==",
    "id": "cea170cc-a58f-6531-fc4b-fae1ceb1a6c8",
    "kind": "ts.target",
    "lastupdated": "2019-01-24T19:32:31.841Z",
    "name": "AWS Target",
    "region": "us-east-1",
    "version": "1.0",
    "versionid": "caf85ff7-200e-11e9-a85b-02420a621e0a"
  }
]
```


# Delete Target

Remove a target from a ThingSpace account.

```go
DeleteTarget(
    ctx context.Context,
    body models.DeleteTargetRequest) (
    http.Response,
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DeleteTargetRequest`](../../doc/models/delete-target-request.md) | Body, Required | The request body identifies the target to delete. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```go
ctx := context.Background()

body := models.DeleteTargetRequest{
    Accountidentifier:     models.ToPointer(models.AccountIdentifier{
        Billingaccountid:      models.ToPointer("0000000000-00001"),
    }),
    Resourceidentifier:    models.ToPointer(models.ResourceIdentifier{
        Id:                    models.ToPointer("2e61a17d-8fd1-6816-e995-e4c2528bf535"),
    }),
}

resp, err := targetsApi.DeleteTarget(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    fmt.Println(resp.StatusCode)
}
```


# Create Target

Define a target to receive data streams, alerts, or callbacks. After creating the target resource, use its ID in a subscription to set up a data stream.

```go
CreateTarget(
    ctx context.Context,
    body models.CreateTargetRequest) (
    models.ApiResponse[models.Target],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.CreateTargetRequest`](../../doc/models/create-target-request.md) | Body, Required | The request body provides the details of the target that you want to create. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.Target](../../doc/models/target.md).

## Example Usage

```go
ctx := context.Background()

body := models.CreateTargetRequest{
    Accountidentifier:     models.ToPointer(models.AccountIdentifier{
        Billingaccountid:      models.ToPointer("0000000000-00001"),
    }),
    Billingaccountid:      models.ToPointer("0000000000-00001"),
    Kind:                  models.ToPointer("ts.target"),
    Address:               models.ToPointer("https://your_IoT_Central_Application.azureiotcentral.com"),
    Addressscheme:         models.ToPointer("streamazureiot"),
    Fields:                models.ToPointer(models.CreateTargetRequestFields{
        Httpheaders:           models.ToPointer(models.FieldsHttpHeaders{
            Authorization:         models.ToPointer("SharedAccessSignature sr=d1f9b6bf-1380-41f6-b757-d9805e48392b&sig=EF5tnXClw3MWkb84OkIOUhMH%2FaS1DRD2nXT69QR8RD8%3D&skn=TSCCtoken&se=1648827260410"),
        }),
        Devicetypes:           []string{
            "cHeAssetTracker",
            "cHeAssetTrackerV2",
            "tgAssetTracker",
            "tgAssetTrackerV2",
        },
    }),
}

apiResponse, err := targetsApi.CreateTarget(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
{
  "address": "arn:aws:iam::252156542978:role/ThingSpace",
  "addressscheme": "streamawsiot",
  "billingaccountid": "1223334444-00001",
  "createdon": "2018-12-21T04:37:42.651Z",
  "externalid": "lJZnih8BfqsosZrEEkfPuR3aGOk2i-HIr6tXN275ioJF6bezIrQB9EbzpTRep8J7RmV7QH==",
  "id": "0e411230-c3eb-64dc-f5f4-1020364aa81f",
  "kind": "ts.target",
  "lastupdated": "2018-12-21T04:37:42.651Z",
  "name": "AWS Target",
  "region": "us-east-1",
  "version": "1.0",
  "versionid": "27aca5a4-04da-11e9-bff3-02420a5e1b0b"
}
```


# Generate Target External ID

Create a unique string that ThingSpace will pass to AWS for increased security.

```go
GenerateTargetExternalId(
    ctx context.Context,
    body models.GenerateExternalIdRequest) (
    models.ApiResponse[models.GenerateExternalIdResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.GenerateExternalIdRequest`](../../doc/models/generate-external-id-request.md) | Body, Required | The request body only contains the authenticating account. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.GenerateExternalIdResult](../../doc/models/generate-external-id-result.md).

## Example Usage

```go
ctx := context.Background()

body := models.GenerateExternalIdRequest{
    Accountidentifier:     models.ToPointer(models.AccountIdentifier{
        Billingaccountid:      models.ToPointer("0000000000-00001"),
    }),
}

apiResponse, err := targetsApi.GenerateTargetExternalId(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
{
  "externalid": "ZlJnih8BfqsosZrEEkfPuR3aGOk2i-HIr6tXN275ioJF6bezIrQB9EbzpTRep8J7RmV7QH=="
}
```


# Create Azure Central Io T Application

Deploy a new Azure IoT Central application based on the Verizon ARM template within the specified Azure Active Directory account.

```go
CreateAzureCentralIoTApplication(
    ctx context.Context,
    billingaccountId string,
    body models.CreateIoTApplicationRequest) (
    models.ApiResponse[models.CreateIoTApplicationResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `billingaccountId` | `string` | Header, Required | TThe ThingSpace ID of the authenticating billing account. |
| `body` | [`models.CreateIoTApplicationRequest`](../../doc/models/create-io-t-application-request.md) | Body, Required | The request body must include the UUID of the subscription that you want to update plus any properties that you want to change. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.CreateIoTApplicationResponse](../../doc/models/create-io-t-application-response.md).

## Example Usage

```go
ctx := context.Background()

billingaccountId := "BillingaccountID2"

body := models.CreateIoTApplicationRequest{
    AppName:               models.ToPointer("newarmapp1"),
    BillingAccountId:      models.ToPointer("0000123456-00001"),
    ClientId:              models.ToPointer("UUID"),
    ClientSecret:          models.ToPointer("client secret"),
    EmailIDs:              models.ToPointer("email@domain.com"),
    Resourcegroup:         models.ToPointer("Myresourcegroup"),
    SampleIoTcApp:         models.ToPointer("{app ID}"),
    SubscriptionId:        models.ToPointer("{subscription ID}"),
    TenantId:              models.ToPointer("{tenant ID}"),
}

apiResponse, err := targetsApi.CreateAzureCentralIoTApplication(ctx, billingaccountId, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
{
  "appName": "newarmapp1",
  "sharedSecret": "SharedAccessSignaturesr={client secret}",
  "url": "https://newarmapp1.azureiotcentral.com"
}
```

