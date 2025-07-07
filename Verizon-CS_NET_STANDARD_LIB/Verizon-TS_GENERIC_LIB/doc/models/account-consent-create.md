
# Account Consent Create

*This model accepts additional fields of type unknown.*

## Structure

`AccountConsentCreate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deviceList` | `unknown[] \| undefined` | Optional | An array of device identifiers |
| `accountName` | `string \| undefined` | Optional | The numeric name of the account, including leading zeros. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "deviceList": [
    {
      "key1": "val1",
      "key2": "val2"
    },
    {
      "key1": "val1",
      "key2": "val2"
    },
    {
      "key1": "val1",
      "key2": "val2"
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

