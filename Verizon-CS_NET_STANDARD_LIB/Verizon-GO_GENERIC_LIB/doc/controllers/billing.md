# Billing

```go
billingApi := client.BillingApi()
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

```go
AddAccount(
    ctx context.Context,
    body models.ManagedAccountsAddRequest) (
    models.ApiResponse[models.ManagedAccountsAddResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ManagedAccountsAddRequest`](../../doc/models/managed-accounts-add-request.md) | Body, Required | Service name and list of accounts to add |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ManagedAccountsAddResponse](../../doc/models/managed-accounts-add-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.ManagedAccountsAddRequest{
    AccountName:           "1234567890-00001",
    ServiceName:           models.ServiceName_Location,
    Type:                  "TS-LOC-COARSE-CellID-Aggr",
    ManagedAccList:        []string{
        "1223334444-00001",
        "2334445555-00001",
        "3445556666-00001",
    },
}

apiResponse, err := billingApi.AddAccount(ctx, body)
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

```go
ManagedAccountAction(
    ctx context.Context,
    body models.ManagedAccountsProvisionRequest) (
    models.ApiResponse[models.ManagedAccountsProvisionResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ManagedAccountsProvisionRequest`](../../doc/models/managed-accounts-provision-request.md) | Body, Required | Service name and list of accounts to add |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ManagedAccountsProvisionResponse](../../doc/models/managed-accounts-provision-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.ManagedAccountsProvisionRequest{
    AccountName:           "1223334444-00001",
    PaccountName:          "1234567890-00001",
    ServiceName:           models.ServiceName_Location,
    Type:                  "TS-LOC-COARSE-CellID-5K",
    Txid:                  "d4fbff33-eeee-ffff-gggg-2c90bd287e3b",
}

apiResponse, err := billingApi.ManagedAccountAction(ctx, body)
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

```go
CancelManagedAccountAction(
    ctx context.Context,
    body models.ManagedAccountCancelRequest) (
    models.ApiResponse[models.ManagedAccountCancelResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ManagedAccountCancelRequest`](../../doc/models/managed-account-cancel-request.md) | Body, Required | Service name and list of accounts to add |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ManagedAccountCancelResponse](../../doc/models/managed-account-cancel-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.ManagedAccountCancelRequest{
    AccountName:           "1223334444-00001",
    PaccountName:          "1234567890-00001",
    ServiceName:           models.ServiceName_Location,
    Type:                  "TS-LOC-COARSE-CellID-5K",
    Txid:                  "d4fbff33-eeee-ffff-gggg-2c90bd287e3b",
}

apiResponse, err := billingApi.CancelManagedAccountAction(ctx, body)
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

```go
ListManagedAccount(
    ctx context.Context,
    accountName string,
    serviceName string) (
    models.ApiResponse[models.ManagedAccountsGetAllResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Primary account identifier |
| `serviceName` | `string` | Template, Required | Service name |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ManagedAccountsGetAllResponse](../../doc/models/managed-accounts-get-all-response.md).

## Example Usage

```go
ctx := context.Background()

accountName := "1223334444-00001"

serviceName := "serviceName8"

apiResponse, err := billingApi.ListManagedAccount(ctx, accountName, serviceName)
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

