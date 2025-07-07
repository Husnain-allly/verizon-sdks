
# Fota V2 Subscription

FOTA Subscription.

*This model accepts additional fields of type interface{}.*

## Structure

`FotaV2Subscription`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `*string` | Optional | Account identifier in "##########-#####". |
| `PurchaseType` | `*string` | Optional | Subscription models used by the account. |
| `LicenseCount` | `*int` | Optional | Number of monthly licenses in an MRC subscription. |
| `LicenseUsedCount` | `*int` | Optional | Number of licenses currently assigned to devices. |
| `UpdateTime` | `*string` | Optional | The date and time of when the subscription was last updated. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "00000000000-123345",
  "purchaseType": "TS-HFOTA-EVNT,TS-HFOTA-MRC",
  "licenseCount": 500,
  "licenseUsedCount": 400,
  "updateTime": "2021-06-03 00:03:56.079 +0000 UTC",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

