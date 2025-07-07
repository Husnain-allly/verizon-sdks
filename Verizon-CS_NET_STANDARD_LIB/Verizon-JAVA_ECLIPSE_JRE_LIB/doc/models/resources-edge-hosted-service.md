
# Resources Edge Hosted Service

Edge hosted service represented by Service Endpoint definition.

*This model accepts additional fields of type Object.*

## Structure

`ResourcesEdgeHostedService`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Ern` | `String` | Optional | Edge Resource Name. A string identifier for a set of edge resources.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9-_]{3,32}$` | String getErn() | setErn(String ern) |
| `ServiceEndpoint` | [`ResourcesServiceEndpoint`](../../doc/models/resources-service-endpoint.md) | Optional | Service Endpoint path, address, and port. | ResourcesServiceEndpoint getServiceEndpoint() | setServiceEndpoint(ResourcesServiceEndpoint serviceEndpoint) |
| `ApplicationServerProviderId` | `String` | Optional | Unique ID representing the Edge Application Provider.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getApplicationServerProviderId() | setApplicationServerProviderId(String applicationServerProviderId) |
| `ApplicationId` | `String` | Optional | Unique ID representing the Edge Application.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getApplicationId() | setApplicationId(String applicationId) |
| `ServiceDescription` | `String` | Optional | **Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getServiceDescription() | setServiceDescription(String serviceDescription) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "ern": "LASVEGAS_NV_WL",
  "applicationServerProviderId": "AWS",
  "applicationId": "IogspaceJan15",
  "serviceDescription": "ThieIt",
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

