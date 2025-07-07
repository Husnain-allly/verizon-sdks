
# Aggregate Session Report Request

Request for getting an aggregated session report.

*This model accepts additional fields of type Object.*

## Structure

`AggregateSessionReportRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountNumber` | `String` | Required | The unique identifier for the account. | String getAccountNumber() | setAccountNumber(String accountNumber) |
| `StartDate` | `String` | Optional | Start date of session to include. If not specified  information will be shown from the earliest available (180 days). Can be either date in ISO 8601 format or predefined constants. | String getStartDate() | setStartDate(String startDate) |
| `EndDate` | `String` | Optional | End date of session to include. If not specified  information will be shown to the latest available. Can be either date in ISO 8601 format or predefined constants. | String getEndDate() | setEndDate(String endDate) |
| `Imei` | `List<String>` | Required | Devices for which return usage info. Could be 0, 1 or more. In case of 0 will return all devices belonging to customer (except of filtered by other parameters). | List<String> getImei() | setImei(List<String> imei) |
| `DeviceGroup` | `String` | Optional | User defined group name the devices are a member of. | String getDeviceGroup() | setDeviceGroup(String deviceGroup) |
| `DeviceLabel` | `String` | Optional | Optional filter parameter. | String getDeviceLabel() | setDeviceLabel(String deviceLabel) |
| `DataPlan` | `String` | Optional | The data plan the devices beign queried belong to. | String getDataPlan() | setDataPlan(String dataPlan) |
| `NoSessionFlag` | `String` | Optional | Optional filter parameter which return only devices with no sessions. | String getNoSessionFlag() | setNoSessionFlag(String noSessionFlag) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountNumber": "0844021539-00001",
  "startDate": "2022-12-09T22:01:06.217Z",
  "endDate": "2022-12-09T22:01:08.734Z",
  "imei": [
    "709312034493372"
  ],
  "deviceGroup": null,
  "dataPlan": null,
  "noSessionFlag": "false",
  "deviceLabel": "deviceLabel4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

