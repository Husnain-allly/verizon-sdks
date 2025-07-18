
# Get Account Device Consent

*This model accepts additional fields of type unknown.*

## Structure

`GetAccountDeviceConsent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deviceList` | `unknown[] \| undefined` | Optional | An array of device identifiers |
| `accountName` | `string \| undefined` | Optional | The numeric name of the account, including leading zeros. |
| `allDeviceConsent` | `number \| undefined` | Optional | If consent is set at the account level, this value will show the consent level. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "allDeviceConsent": 1,
  "deviceList": [
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

