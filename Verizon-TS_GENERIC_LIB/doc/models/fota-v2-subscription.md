
# Fota V2 Subscription

FOTA Subscription.

*This model accepts additional fields of type unknown.*

## Structure

`FotaV2Subscription`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string \| undefined` | Optional | Account identifier in "##########-#####". |
| `purchaseType` | `string \| undefined` | Optional | Subscription models used by the account. |
| `licenseCount` | `number \| undefined` | Optional | Number of monthly licenses in an MRC subscription. |
| `licenseUsedCount` | `number \| undefined` | Optional | Number of licenses currently assigned to devices. |
| `updateTime` | `string \| undefined` | Optional | The date and time of when the subscription was last updated. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

