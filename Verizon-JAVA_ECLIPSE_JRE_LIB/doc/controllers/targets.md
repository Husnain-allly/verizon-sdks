# Targets

```java
TargetsApi targetsApi = client.getTargetsApi();
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

```java
CompletableFuture<ApiResponse<List<Target>>> queryTargetAsync(
    final QueryTargetRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`QueryTargetRequest`](../../doc/models/query-target-request.md) | Body, Required | Search for targets by property values. |

## Server

`Server.CLOUD_CONNECTOR`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<Target>`](../../doc/models/target.md).

## Example Usage

```java
QueryTargetRequest body = new QueryTargetRequest.Builder()
    .accountidentifier(new AccountIdentifier.Builder()
        .billingaccountid("1223334444-00001")
        .build())
    .resourceidentifier(new ResourceIdentifier.Builder()
        .id("dd1682d3-2d80-cefc-f3ee-25154800beff")
        .build())
    .build();

targetsApi.queryTargetAsync(body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

```java
CompletableFuture<ApiResponse<Void>> deleteTargetAsync(
    final DeleteTargetRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeleteTargetRequest`](../../doc/models/delete-target-request.md) | Body, Required | The request body identifies the target to delete. |

## Server

`Server.CLOUD_CONNECTOR`

## Response Type

`void`

## Example Usage

```java
DeleteTargetRequest body = new DeleteTargetRequest.Builder()
    .accountidentifier(new AccountIdentifier.Builder()
        .billingaccountid("0000000000-00001")
        .build())
    .resourceidentifier(new ResourceIdentifier.Builder()
        .id("2e61a17d-8fd1-6816-e995-e4c2528bf535")
        .build())
    .build();

targetsApi.deleteTargetAsync(body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```


# Create Target

Define a target to receive data streams, alerts, or callbacks. After creating the target resource, use its ID in a subscription to set up a data stream.

```java
CompletableFuture<ApiResponse<Target>> createTargetAsync(
    final CreateTargetRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreateTargetRequest`](../../doc/models/create-target-request.md) | Body, Required | The request body provides the details of the target that you want to create. |

## Server

`Server.CLOUD_CONNECTOR`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`Target`](../../doc/models/target.md).

## Example Usage

```java
CreateTargetRequest body = new CreateTargetRequest.Builder()
    .accountidentifier(new AccountIdentifier.Builder()
        .billingaccountid("0000000000-00001")
        .build())
    .billingaccountid("0000000000-00001")
    .kind("ts.target")
    .address("https://your_IoT_Central_Application.azureiotcentral.com")
    .addressscheme("streamazureiot")
    .fields(new CreateTargetRequestFields.Builder()
        .httpheaders(new FieldsHttpHeaders.Builder()
            .authorization("SharedAccessSignature sr=d1f9b6bf-1380-41f6-b757-d9805e48392b&sig=EF5tnXClw3MWkb84OkIOUhMH%2FaS1DRD2nXT69QR8RD8%3D&skn=TSCCtoken&se=1648827260410")
            .build())
        .devicetypes(Arrays.asList(
            "cHeAssetTracker",
            "cHeAssetTrackerV2",
            "tgAssetTracker",
            "tgAssetTrackerV2"
        ))
        .build())
    .build();

targetsApi.createTargetAsync(body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

```java
CompletableFuture<ApiResponse<GenerateExternalIdResult>> generateTargetExternalIdAsync(
    final GenerateExternalIdRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GenerateExternalIdRequest`](../../doc/models/generate-external-id-request.md) | Body, Required | The request body only contains the authenticating account. |

## Server

`Server.CLOUD_CONNECTOR`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`GenerateExternalIdResult`](../../doc/models/generate-external-id-result.md).

## Example Usage

```java
GenerateExternalIdRequest body = new GenerateExternalIdRequest.Builder()
    .accountidentifier(new AccountIdentifier.Builder()
        .billingaccountid("0000000000-00001")
        .build())
    .build();

targetsApi.generateTargetExternalIdAsync(body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Example Response *(as JSON)*

```json
{
  "externalid": "ZlJnih8BfqsosZrEEkfPuR3aGOk2i-HIr6tXN275ioJF6bezIrQB9EbzpTRep8J7RmV7QH=="
}
```


# Create Azure Central Io T Application

Deploy a new Azure IoT Central application based on the Verizon ARM template within the specified Azure Active Directory account.

```java
CompletableFuture<ApiResponse<CreateIoTApplicationResponse>> createAzureCentralIoTApplicationAsync(
    final String billingaccountId,
    final CreateIoTApplicationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `billingaccountId` | `String` | Header, Required | TThe ThingSpace ID of the authenticating billing account. |
| `body` | [`CreateIoTApplicationRequest`](../../doc/models/create-io-t-application-request.md) | Body, Required | The request body must include the UUID of the subscription that you want to update plus any properties that you want to change. |

## Server

`Server.CLOUD_CONNECTOR`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`CreateIoTApplicationResponse`](../../doc/models/create-io-t-application-response.md).

## Example Usage

```java
String billingaccountId = "BillingaccountID2";
CreateIoTApplicationRequest body = new CreateIoTApplicationRequest.Builder()
    .appName("newarmapp1")
    .billingAccountId("0000123456-00001")
    .clientId("UUID")
    .clientSecret("client secret")
    .emailIDs("email@domain.com")
    .resourcegroup("Myresourcegroup")
    .sampleIoTcApp("{app ID}")
    .subscriptionId("{subscription ID}")
    .tenantId("{tenant ID}")
    .build();

targetsApi.createAzureCentralIoTApplicationAsync(billingaccountId, body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Example Response *(as JSON)*

```json
{
  "appName": "newarmapp1",
  "sharedSecret": "SharedAccessSignaturesr={client secret}",
  "url": "https://newarmapp1.azureiotcentral.com"
}
```

