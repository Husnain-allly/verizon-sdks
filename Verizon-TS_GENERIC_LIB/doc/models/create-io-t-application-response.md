
# Create Io T Application Response

A success response includes an array of all matching events. Each event includes the full event resource definition.

*This model accepts additional fields of type unknown.*

## Structure

`CreateIoTApplicationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `appName` | `string \| undefined` | Optional | An application will be created under the user's Azure subscription with this name and of type IOT central. |
| `sharedSecret` | `string \| undefined` | Optional | Part of the user credentials (from Azure) the user needs to use for calling further TS Core APIs for setting up Azure cloud connector. |
| `url` | `string \| undefined` | Optional | An IOT central endpoint the user can use to see the data that is being streamed. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "appName": "newarmapp1",
  "sharedSecret": "SharedAccessSignaturesr={client secret}",
  "url": "https://newarmapp1.azureiotcentral.com",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

