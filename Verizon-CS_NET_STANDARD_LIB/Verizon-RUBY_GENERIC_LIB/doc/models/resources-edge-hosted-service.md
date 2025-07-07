
# Resources Edge Hosted Service

Edge hosted service represented by Service Endpoint definition.

*This model accepts additional fields of type Object.*

## Structure

`ResourcesEdgeHostedService`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ern` | `String` | Optional | Edge Resource Name. A string identifier for a set of edge resources.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9-_]{3,32}$` |
| `service_endpoint` | [`ResourcesServiceEndpoint`](../../doc/models/resources-service-endpoint.md) | Optional | Service Endpoint path, address, and port. |
| `application_server_provider_id` | `String` | Optional | Unique ID representing the Edge Application Provider.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `application_id` | `String` | Optional | Unique ID representing the Edge Application.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `service_description` | `String` | Optional | **Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

