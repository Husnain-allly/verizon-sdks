
# Fota V1 Callback Registration Result

Registered callback account name and service name.

*This model accepts additional fields of type unknown.*

## Structure

`FotaV1CallbackRegistrationResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string \| undefined` | Optional | The name of the billing account for which callback messages will be sent. |
| `serviceName` | `string \| undefined` | Optional | The name of the callback service, which identifies the type and format of messages that will be sent to the registered URL. This will be 'Fota' for the Software Management Services callback. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0204563412-00001",
  "serviceName": "Fota",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

