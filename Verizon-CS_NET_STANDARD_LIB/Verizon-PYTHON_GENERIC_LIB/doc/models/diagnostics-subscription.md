
# Diagnostics Subscription

Status of the diagnostic services subscription.

*This model accepts additional fields of type Any.*

## Structure

`DiagnosticsSubscription`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `str` | Required | Account identifier in "##########-#####". An account name is usually numeric, and must include any leading zeros. |
| `created_on` | `datetime` | Required | The date and time of when the subscription was created. |
| `last_updated` | `datetime` | Required | The date and time of when the subscription was last updated. |
| `total_allowed` | `int` | Required | Number of licenses currently assigned to devices. |
| `total_used` | `int` | Required | Number of licenses currently used by the devices. |
| `sku_name` | `str` | Required | Name of the SKU for the account. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "TestQAAccount",
  "skuName": "TS-BUNDLE-KTO-DIAGNOSTIC-MRC",
  "totalAllowed": 100,
  "totalUsed": 50,
  "createdOn": "2019-08-29T00:47:59.240Z",
  "lastUpdated": "2019-08-29T00:47:59.240Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

