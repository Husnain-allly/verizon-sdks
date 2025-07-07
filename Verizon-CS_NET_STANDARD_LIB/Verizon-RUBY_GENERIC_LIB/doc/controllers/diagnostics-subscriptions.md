# Diagnostics Subscriptions

```ruby
diagnostics_subscriptions_api = client.diagnostics_subscriptions
```

## Class Name

`DiagnosticsSubscriptionsApi`


# Get Diagnostics Subscription

This endpoint retrieves a diagnostics subscription by account.

```ruby
def get_diagnostics_subscription(account_name)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Query, Required | Account identifier. |

## Server

`Server::DEVICE_DIAGNOSTICS`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`DiagnosticsSubscription`](../../doc/models/diagnostics-subscription.md).

## Example Usage

```ruby
account_name = '0000123456-00001'

result = diagnostics_subscriptions_api.get_diagnostics_subscription(account_name)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Example Response *(as JSON)*

```json
{
  "accountName": "TestQAAccount",
  "skuName": "TS-BUNDLE-KTO-DIAGNOSTIC-MRC",
  "totalAllowed": 100,
  "totalUsed": 50,
  "createdOn": "2019-08-29T00:47:59.240Z",
  "lastUpdated": "2019-08-29T00:47:59.240Z"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |

