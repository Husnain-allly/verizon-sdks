
# Resources Edge Hosted Service With Profile Id

Edge hosted service represented by Service Endpoint definition.

*This model accepts additional fields of type unknown.*

## Structure

`ResourcesEdgeHostedServiceWithProfileId`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ern` | `string \| undefined` | Optional | Edge Resource Name. A string identifier for a set of edge resources.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9-]{3,32}$` |
| `serviceEndpoint` | [`ResourcesServiceEndpoint \| undefined`](../../doc/models/resources-service-endpoint.md) | Optional | Service Endpoint path, address, and port. |
| `applicationServerProviderId` | `string \| undefined` | Optional | Unique ID representing the Edge Application Provider.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `applicationId` | `string \| undefined` | Optional | Unique ID representing the Edge Application.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `serviceDescription` | `string \| undefined` | Optional | **Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `serviceProfileId` | `string \| undefined` | Optional | The system assigned ID of the service profile. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "ern": "us-east-1-wl1-atl-wlz-1",
  "applicationServerProviderId": "AWS",
  "applicationId": "IogspaceJan15",
  "serviceDescription": "ThieIt",
  "serviceProfileID": "4054ea9a-593e-4776-b488-697b1bfa4f3b",
  "serviceEndpoint": {
    "URI": "URI6",
    "FQDN": "FQDN2",
    "IPv4Address": "IPv4Address4",
    "IPv6Address": "IPv6Address8",
    "port": 16
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

