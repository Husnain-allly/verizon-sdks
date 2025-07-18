
# Create Target Request

Details of the target that you want to create.

*This model accepts additional fields of type array.*

## Structure

`CreateTargetRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountidentifier` | [`?AccountIdentifier`](../../doc/models/account-identifier.md) | Optional | The ID of the authenticating billing account, in the format `{"billingaccountid":"1234567890-12345"}`. | getAccountidentifier(): ?AccountIdentifier | setAccountidentifier(?AccountIdentifier accountidentifier): void |
| `billingaccountid` | `?string` | Optional | The ID of the authenticating billing account. | getBillingaccountid(): ?string | setBillingaccountid(?string billingaccountid): void |
| `kind` | `?string` | Optional | Identifies the resource kind. Targets are ts.target. | getKind(): ?string | setKind(?string kind): void |
| `address` | `?string` | Optional | The endpoint for notifications or data streams. The format depends on the selected `addressscheme`.<br />`streamrest` requires a `host:port` value <br />`streamawsiot` requres a valid ARN. | getAddress(): ?string | setAddress(?string address): void |
| `addressscheme` | `?string` | Optional | The transport format. Valid values are: <br />streamawsiot - streamed data to an AWS account <br />streamrest - streamed REST data to a defined endpoint. | getAddressscheme(): ?string | setAddressscheme(?string addressscheme): void |
| `fields` | [`?CreateTargetRequestFields`](../../doc/models/create-target-request-fields.md) | Optional | - | getFields(): ?CreateTargetRequestFields | setFields(?CreateTargetRequestFields fields): void |
| `description` | `?string` | Optional | Descriptive information about the target. | getDescription(): ?string | setDescription(?string description): void |
| `externalid` | `?string` | Optional | Security identification string created by a POST /targets/actions/newextid request. | getExternalid(): ?string | setExternalid(?string externalid): void |
| `name` | `?string` | Optional | Name of the target. | getName(): ?string | setName(?string name): void |
| `region` | `?string` | Optional | AWS region value. | getRegion(): ?string | setRegion(?string region): void |
| `key1` | `?string` | Optional | OAuth 2.0 bearer token. | getKey1(): ?string | setKey1(?string key1): void |
| `oauth` | [`?TargetAuthentication`](../../doc/models/target-authentication.md) | Optional | OAuth 2 token and refresh token for TS to stream events to Target. | getOauth(): ?TargetAuthentication | setOauth(?TargetAuthentication oauth): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountidentifier": {
    "billingaccountid": "0000000000-00001",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "billingaccountid": "0000000000-00001",
  "kind": "ts.target",
  "address": "https://your_IoT_Central_Application.azureiotcentral.com",
  "addressscheme": "streamazureiot",
  "fields": {
    "httpheaders": {
      "Authorization": "SharedAccessSignature sr=d1f9b6bf-1380-41f6-b757-d9805e48392b&sig=EF5tnXClw3MWkb84OkIOUhMH%2FaS1DRD2nXT69QR8RD8%3D&skn=TSCCtoken&se=1648827260410"
    },
    "devicetypes": [
      "cHeAssetTracker",
      "cHeAssetTrackerV2",
      "tgAssetTracker",
      "tgAssetTrackerV2"
    ]
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

