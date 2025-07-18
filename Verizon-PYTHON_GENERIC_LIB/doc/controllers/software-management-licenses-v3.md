# Software Management Licenses V3

```python
software_management_licenses_v3_api = client.software_management_licenses_v3
```

## Class Name

`SoftwareManagementLicensesV3Api`

## Methods

* [Get Account Licenses Status](../../doc/controllers/software-management-licenses-v3.md#get-account-licenses-status)
* [Assign Licenses to Devices](../../doc/controllers/software-management-licenses-v3.md#assign-licenses-to-devices)
* [Remove Licenses From Devices](../../doc/controllers/software-management-licenses-v3.md#remove-licenses-from-devices)


# Get Account Licenses Status

The endpoint allows user to list license usage.

```python
def get_account_licenses_status(self,
                               acc,
                               last_seen_device_id=None)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `str` | Template, Required | Account identifier. |
| `last_seen_device_id` | `str` | Query, Optional | Last seen device identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`V3LicenseSummary`](../../doc/models/v3-license-summary.md).

## Example Usage

```python
acc = '0000123456-00001'

last_seen_device_id = '0'

result = software_management_licenses_v3_api.get_account_licenses_status(
    acc,
    last_seen_device_id=last_seen_device_id
)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Example Response *(as JSON)*

```json
{
  "accountName": "0000123456-00001",
  "assignedLicenses": 4319,
  "hasMoreData": true,
  "lastSeenDeviceId": "1000",
  "maxPageSize": 1000,
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "assignmentTime": "2017-11-29 20:15:42.738 +0000 UTC"
    },
    {
      "deviceId": "15-digit IMEI",
      "assignmentTime": "2017-11-29 20:15:42.738 +0000 UTC"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Assign Licenses to Devices

This endpoint allows user to assign licenses to a list of devices.

```python
def assign_licenses_to_devices(self,
                              acc,
                              body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `str` | Template, Required | Account identifier. |
| `body` | [`V3LicenseImei`](../../doc/models/v3-license-imei.md) | Body, Required | License assignment. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`V3LicenseAssignedRemovedResult`](../../doc/models/v3-license-assigned-removed-result.md).

## Example Usage

```python
acc = '0000123456-00001'

body = V3LicenseImei(
    device_list=[
        '15-digit IMEI',
        '15-digit IMEI'
    ],
    additional_properties=None
)

result = software_management_licenses_v3_api.assign_licenses_to_devices(
    acc,
    body
)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Example Response *(as JSON)*

```json
{
  "accountName": "0000123456-00001",
  "licUsedCount": 2,
  "licCount": 1000,
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "status": "UpgradePending",
      "resultReason": "Upgrade pending, the device upgrade is estimated to be scheduled for 06 Oct 22 18:05 UTC",
      "updatedTime": "2022-08-05T21:05:27.129Z",
      "recentAttemptTime": "2022-10-05T21:05:01.19Z",
      "nextAttemptTime": "2022-10-06T18:35:00Z"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Remove Licenses From Devices

This endpoint allows user to remove licenses from a list of devices.

```python
def remove_licenses_from_devices(self,
                                acc,
                                body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `str` | Template, Required | Account identifier. |
| `body` | [`V3LicenseImei`](../../doc/models/v3-license-imei.md) | Body, Required | License removal. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`V3LicenseAssignedRemovedResult`](../../doc/models/v3-license-assigned-removed-result.md).

## Example Usage

```python
acc = '0000123456-00001'

body = V3LicenseImei(
    device_list=[
        '15-digit IMEI',
        '15-digit IMEI',
        '15-digit IMEI'
    ],
    additional_properties=None
)

result = software_management_licenses_v3_api.remove_licenses_from_devices(
    acc,
    body
)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Example Response *(as JSON)*

```json
{
  "accountName": "0000123456-00001",
  "licUsedCount": 998,
  "licCount": 1000,
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "status": "UpgradePending",
      "resultReason": "Upgrade pending, the device upgrade is estimated to be scheduled for 06 Oct 22 18:05 UTC",
      "updatedTime": "2022-08-05T21:05:27.129Z",
      "recentAttemptTime": "2022-10-05T21:05:01.19Z",
      "nextAttemptTime": "2022-10-06T18:35:00Z"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |

