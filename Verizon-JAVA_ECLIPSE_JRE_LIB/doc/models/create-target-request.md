
# Create Target Request

Details of the target that you want to create.

*This model accepts additional fields of type Object.*

## Structure

`CreateTargetRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Accountidentifier` | [`AccountIdentifier`](../../doc/models/account-identifier.md) | Optional | The ID of the authenticating billing account, in the format `{"billingaccountid":"1234567890-12345"}`. | AccountIdentifier getAccountidentifier() | setAccountidentifier(AccountIdentifier accountidentifier) |
| `Billingaccountid` | `String` | Optional | The ID of the authenticating billing account. | String getBillingaccountid() | setBillingaccountid(String billingaccountid) |
| `Kind` | `String` | Optional | Identifies the resource kind. Targets are ts.target. | String getKind() | setKind(String kind) |
| `Address` | `String` | Optional | The endpoint for notifications or data streams. The format depends on the selected `addressscheme`.<br />`streamrest` requires a `host:port` value <br />`streamawsiot` requres a valid ARN. | String getAddress() | setAddress(String address) |
| `Addressscheme` | `String` | Optional | The transport format. Valid values are: <br />streamawsiot - streamed data to an AWS account <br />streamrest - streamed REST data to a defined endpoint. | String getAddressscheme() | setAddressscheme(String addressscheme) |
| `Fields` | [`CreateTargetRequestFields`](../../doc/models/create-target-request-fields.md) | Optional | - | CreateTargetRequestFields getFields() | setFields(CreateTargetRequestFields fields) |
| `Description` | `String` | Optional | Descriptive information about the target. | String getDescription() | setDescription(String description) |
| `Externalid` | `String` | Optional | Security identification string created by a POST /targets/actions/newextid request. | String getExternalid() | setExternalid(String externalid) |
| `Name` | `String` | Optional | Name of the target. | String getName() | setName(String name) |
| `Region` | `String` | Optional | AWS region value. | String getRegion() | setRegion(String region) |
| `Key1` | `String` | Optional | OAuth 2.0 bearer token. | String getKey1() | setKey1(String key1) |
| `Oauth` | [`TargetAuthentication`](../../doc/models/target-authentication.md) | Optional | OAuth 2 token and refresh token for TS to stream events to Target. | TargetAuthentication getOauth() | setOauth(TargetAuthentication oauth) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

