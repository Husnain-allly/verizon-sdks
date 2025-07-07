
# Connection Response

response for /clients/connection

## Structure

`ConnectionResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `mqttUrl` | `string` | Required | **Constraints**: *Maximum Length*: `1024`, *Pattern*: `^(http?mqtt)://[^\s/$.?#].[^\s]*$` | getMqttUrl(): string | setMqttUrl(string mqttUrl): void |

## Example (as JSON)

```json
{
  "MqttURL": "MqttURL2"
}
```

