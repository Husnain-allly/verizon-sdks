# Billing

```ruby
billing_api = client.billing
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

```ruby
def add_account(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ManagedAccountsAddRequest`](../../doc/models/managed-accounts-add-request.md) | Body, Required | Service name and list of accounts to add |

## Server

`Server::SUBSCRIPTION_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`ManagedAccountsAddResponse`](../../doc/models/managed-accounts-add-response.md).

## Example Usage

```ruby
body = ManagedAccountsAddRequest.new(
  account_name: '1234567890-00001',
  service_name: ServiceName::LOCATION,
  type: 'TS-LOC-COARSE-CellID-Aggr',
  managed_acc_list: [
    '1223334444-00001',
    '2334445555-00001',
    '3445556666-00001'
  ]
)

result = billing_api.add_account(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
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

```ruby
def managed_account_action(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ManagedAccountsProvisionRequest`](../../doc/models/managed-accounts-provision-request.md) | Body, Required | Service name and list of accounts to add |

## Server

`Server::SUBSCRIPTION_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`ManagedAccountsProvisionResponse`](../../doc/models/managed-accounts-provision-response.md).

## Example Usage

```ruby
body = ManagedAccountsProvisionRequest.new(
  account_name: '1223334444-00001',
  paccount_name: '1234567890-00001',
  service_name: ServiceName::LOCATION,
  type: 'TS-LOC-COARSE-CellID-5K',
  txid: 'd4fbff33-eeee-ffff-gggg-2c90bd287e3b'
)

result = billing_api.managed_account_action(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
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

```ruby
def cancel_managed_account_action(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ManagedAccountCancelRequest`](../../doc/models/managed-account-cancel-request.md) | Body, Required | Service name and list of accounts to add |

## Server

`Server::SUBSCRIPTION_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`ManagedAccountCancelResponse`](../../doc/models/managed-account-cancel-response.md).

## Example Usage

```ruby
body = ManagedAccountCancelRequest.new(
  account_name: '1223334444-00001',
  paccount_name: '1234567890-00001',
  service_name: ServiceName::LOCATION,
  type: 'TS-LOC-COARSE-CellID-5K',
  txid: 'd4fbff33-eeee-ffff-gggg-2c90bd287e3b'
)

result = billing_api.cancel_managed_account_action(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
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

```ruby
def list_managed_account(account_name,
                         service_name)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Template, Required | Primary account identifier |
| `service_name` | `String` | Template, Required | Service name |

## Server

`Server::SUBSCRIPTION_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`ManagedAccountsGetAllResponse`](../../doc/models/managed-accounts-get-all-response.md).

## Example Usage

```ruby
account_name = '1223334444-00001'

service_name = 'serviceName8'

result = billing_api.list_managed_account(
  account_name,
  service_name
)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
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

