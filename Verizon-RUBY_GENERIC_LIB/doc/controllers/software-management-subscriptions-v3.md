# Software Management Subscriptions V3

```ruby
software_management_subscriptions_v3_api = client.software_management_subscriptions_v3
```

## Class Name

`SoftwareManagementSubscriptionsV3Api`


# Get Account Subscription Status

This endpoint retrieves a FOTA subscription by account.

```ruby
def get_account_subscription_status(acc)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `String` | Template, Required | Account identifier. |

## Server

`Server::SOFTWARE_MANAGEMENT_V3`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`FotaV3Subscription`](../../doc/models/fota-v3-subscription.md).

## Example Usage

```ruby
acc = '0000123456-00001'

result = software_management_subscriptions_v3_api.get_account_subscription_status(acc)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Example Response *(as JSON)*

```json
{
  "accountName": "0000123456-000001",
  "purchaseType": "TS-HFOTA-EVNT,TS-HFOTA-MRC",
  "licenseCount": 500,
  "licenseUsedCount": 400,
  "updateTime": "2020-09-17T21:11:32.170Z"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |

