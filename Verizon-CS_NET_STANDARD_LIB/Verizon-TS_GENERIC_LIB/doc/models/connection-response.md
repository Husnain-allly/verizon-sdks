
# Connection Response

response for /clients/connection

## Structure

`ConnectionResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mqttUrl` | `string` | Required | **Constraints**: *Maximum Length*: `1024`, *Pattern*: `^(http?mqtt)://[^\s/$.?#].[^\s]*$` |

## Example (as JSON)

```json
{
  "MqttURL": "MqttURL2"
}
```

