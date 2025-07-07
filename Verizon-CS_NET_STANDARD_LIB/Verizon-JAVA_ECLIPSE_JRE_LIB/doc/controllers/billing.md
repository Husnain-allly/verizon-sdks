# Billing

```java
BillingApi billingApi = client.getBillingApi();
```

## Class Name

`BillingApi`

## Methods

* [Add Account](../../doc/controllers/billing.md#add-account)
* [Managed Account Action](../../doc/controllers/billing.md#managed-account-action)
* [Cancel Managed Account Action](../../doc/controllers/billing.md#cancel-managed-account-action)
* [List Managed Account](../../doc/controllers/billing.md#list-managed-account)


# Add Account

This endpoint allows user to add managed accounts to a primary account.

```java
CompletableFuture<ApiResponse<ManagedAccountsAddResponse>> addAccountAsync(
    final ManagedAccountsAddRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ManagedAccountsAddRequest`](../../doc/models/managed-accounts-add-request.md) | Body, Required | Service name and list of accounts to add |

## Server

`Server.SUBSCRIPTION_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`ManagedAccountsAddResponse`](../../doc/models/managed-accounts-add-response.md).

## Example Usage

```java
ManagedAccountsAddRequest body = new ManagedAccountsAddRequest.Builder(
    "1234567890-00001",
    ServiceName.LOCATION,
    "TS-LOC-COARSE-CellID-Aggr",
    Arrays.asList(
        "1223334444-00001",
        "2334445555-00001",
        "3445556666-00001"
    )
)
.build();

billingApi.addAccountAsync(body).thenAccept(result -> {
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
  "txid": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33",
  "statusList": [
    {
      "id": "1223334444-00001",
      "status": "Success",
      "reason": "Success"
    },
    {
      "id": "2334445555-00001",
      "status": "Success",
      "reason": "Success"
    },
    {
      "id": "3445556666-00001",
      "status": "Success",
      "reason": "Success"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Managed Account Action

Activates a managed billing service relationship between a managed account and the primary account.

```java
CompletableFuture<ApiResponse<ManagedAccountsProvisionResponse>> managedAccountActionAsync(
    final ManagedAccountsProvisionRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ManagedAccountsProvisionRequest`](../../doc/models/managed-accounts-provision-request.md) | Body, Required | Service name and list of accounts to add |

## Server

`Server.SUBSCRIPTION_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`ManagedAccountsProvisionResponse`](../../doc/models/managed-accounts-provision-response.md).

## Example Usage

```java
ManagedAccountsProvisionRequest body = new ManagedAccountsProvisionRequest.Builder(
    "1223334444-00001",
    "1234567890-00001",
    ServiceName.LOCATION,
    "TS-LOC-COARSE-CellID-5K",
    "d4fbff33-eeee-ffff-gggg-2c90bd287e3b"
)
.build();

billingApi.managedAccountActionAsync(body).thenAccept(result -> {
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
  "txid": "4fbff332-eeee-ffff-gggg-7e3bdc90bd28",
  "accountName": "1223334444-00001",
  "paccountName": "1234567890-00001",
  "serviceName": "Location",
  "status": "Success",
  "reason": "Success"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Cancel Managed Account Action

Deactivates a managed billing service relationship between a managed account and the primary account.

```java
CompletableFuture<ApiResponse<ManagedAccountCancelResponse>> cancelManagedAccountActionAsync(
    final ManagedAccountCancelRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ManagedAccountCancelRequest`](../../doc/models/managed-account-cancel-request.md) | Body, Required | Service name and list of accounts to add |

## Server

`Server.SUBSCRIPTION_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`ManagedAccountCancelResponse`](../../doc/models/managed-account-cancel-response.md).

## Example Usage

```java
ManagedAccountCancelRequest body = new ManagedAccountCancelRequest.Builder(
    "1223334444-00001",
    "1234567890-00001",
    ServiceName.LOCATION,
    "TS-LOC-COARSE-CellID-5K",
    "d4fbff33-eeee-ffff-gggg-2c90bd287e3b"
)
.build();

billingApi.cancelManagedAccountActionAsync(body).thenAccept(result -> {
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
  "txid": "4fbff332-eeee-ffff-gggg-7e3bdc90bd28",
  "accountName": "1223334444-00001",
  "paccountName": "1234567890-00001",
  "serviceName": "Location",
  "status": "Success",
  "reason": "Success"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# List Managed Account

This endpoint allows user to retrieve the list of all accounts managed by a primary account.

```java
CompletableFuture<ApiResponse<ManagedAccountsGetAllResponse>> listManagedAccountAsync(
    final String accountName,
    final String serviceName)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `String` | Template, Required | Primary account identifier |
| `serviceName` | `String` | Template, Required | Service name |

## Server

`Server.SUBSCRIPTION_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`ManagedAccountsGetAllResponse`](../../doc/models/managed-accounts-get-all-response.md).

## Example Usage

```java
String accountName = "1223334444-00001";
String serviceName = "serviceName8";

billingApi.listManagedAccountAsync(accountName, serviceName).thenAccept(result -> {
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
  "accountName": "2024009649-00001",
  "ManagedAccAddedList": [
    {
      "id": "1223334444-00001",
      "txid": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33"
    },
    {
      "id": "2334445555-00001",
      "txid": "d4fbff33-eeee-ffff-gggg-2c90bd287e3b"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |

