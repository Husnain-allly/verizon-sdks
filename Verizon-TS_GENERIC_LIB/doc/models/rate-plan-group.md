
# Rate Plan Group

*This model accepts additional fields of type unknown.*

## Structure

`RatePlanGroup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ratePlanGroupDescription` | `string \| undefined` | Optional | - |
| `ratePlanType` | `unknown \| undefined` | Optional | - |
| `ratePlan` | [`Rateplantype2[] \| undefined`](../../doc/models/rateplantype-2.md) | Optional | An array of rateplan names |
| `description` | `string \| undefined` | Optional | - |
| `sizeKb` | `string \| undefined` | Optional | - |
| `carrierRatePlanCode` | `string \| undefined` | Optional | - |
| `zeroDollarBilling` | `boolean \| undefined` | Optional | - |
| `promotionOffered` | `boolean \| undefined` | Optional | - |
| `promotionDays` | `number \| undefined` | Optional | - |
| `account` | [`Accountid[] \| undefined`](../../doc/models/accountid.md) | Optional | Account information |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "ratePlanGroupDescription": "AGS Description_73",
  "description": "PlanDescription 2",
  "sizeKb": "1048576",
  "carrierRatePlanCode": "Service plan code value",
  "zeroDollarBilling": false,
  "promotionOffered": false,
  "promotionDays": -2147483648,
  "ratePlanType": {
    "key1": "val1",
    "key2": "val2"
  },
  "ratePlan": [
    {
      "description": "description2",
      "sizeKb": "sizeKb2",
      "carrierRatePlanCode": "carrierRatePlanCode8",
      "zeroDollarBilling": false,
      "promotionOffered": false,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

