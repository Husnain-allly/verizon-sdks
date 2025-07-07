
# V1 Account Subscription

Account subscription information.

*This model accepts additional fields of type object.*

## Structure

`V1AccountSubscription`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | Account identifier in "##########-#####". |
| `PurchaseType` | `string` | Optional | Subscription models used by the account. |
| `LicenseCount` | `int?` | Optional | Number of monthly licenses in an MRC subscription. |
| `LicenseUsedCount` | `int?` | Optional | Number of licenses currently assigned to devices. |
| `UpdateTime` | `string` | Optional | The date and time of when the subscription was last updated. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0402196254-00001",
  "purchaseType": "TS-HFOTA-EVNT,TS-HFOTA-MRC",
  "licenseCount": 9000,
  "licenseUsedCount": 1000,
  "updateTime": "2018-03-02T16:03:06.000Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

