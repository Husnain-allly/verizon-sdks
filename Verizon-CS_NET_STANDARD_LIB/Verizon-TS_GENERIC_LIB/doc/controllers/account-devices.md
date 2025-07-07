# Account Devices

```ts
const accountDevicesApi = new AccountDevicesApi(client);
```

## Class Name

`AccountDevicesApi`

## Methods

* [Get Account Device Information](../../doc/controllers/account-devices.md#get-account-device-information)
* [List Account Devices Information](../../doc/controllers/account-devices.md#list-account-devices-information)


# Get Account Device Information

Retrieve account device information such as reported firmware on the devices.

```ts
async getAccountDeviceInformation(
  acc: string,
  lastSeenDeviceId?: string,
  protocol?: DevicesProtocol,
  requestOptions?: RequestOptions
): Promise<ApiResponse<V3AccountDeviceList>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `lastSeenDeviceId` | `string \| undefined` | Query, Optional | Last seen device identifier. |
| `protocol` | [`DevicesProtocol \| undefined`](../../doc/models/devices-protocol.md) | Query, Optional | Filter to retrieve a specific protocol type used.<br><br>**Default**: `DevicesProtocol.LwM2M` |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [V3AccountDeviceList](../../doc/models/v3-account-device-list.md).

## Example Usage

```ts
const acc = '0000123456-00001';

const lastSeenDeviceId = '0';

const protocol = DevicesProtocol.LwM2M;

try {
  const { result, ...httpResponse } = await accountDevicesApi.getAccountDeviceInformation(
  acc,
  lastSeenDeviceId,
  protocol
);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultError`](../../doc/models/fota-v3-result-error.md) |


# List Account Devices Information

Retrieve device information for a list of devices on an account.

```ts
async listAccountDevicesInformation(
  acc: string,
  body: DeviceImei,
  requestOptions?: RequestOptions
): Promise<ApiResponse<DeviceListResult>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `body` | [`DeviceImei`](../../doc/models/device-imei.md) | Body, Required | Request device list information. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [DeviceListResult](../../doc/models/device-list-result.md).

## Example Usage

```ts
const acc = '0000123456-00001';

const body: DeviceImei = {
  deviceList: [
    '15-digit IMEI'
  ],
};

try {
  const { result, ...httpResponse } = await accountDevicesApi.listAccountDevicesInformation(
  acc,
  body
);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Example Response *(as JSON)*

```json
{
  "accountName": "0000123456-00001",
  "deviceCount": 1,
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "mdn": "10-digit MDN",
      "model": "GM01Q",
      "make": "SEQUANS COMMUNICATIONS",
      "firmware": "SR1.2.0.0-10657",
      "fotaEligible": true,
      "licenseAssigned": true,
      "status": "Active",
      "protocol": "LWM2M",
      "createTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "statusTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "refreshTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "lastConnectionTime": "2012-04-23T18:25:43.511Z"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultError`](../../doc/models/fota-v3-result-error.md) |

