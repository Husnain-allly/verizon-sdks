# Thing Space Qualityof Service API Actions

```ruby
thing_space_qualityof_service_api_actions_api = client.thing_space_qualityof_service_api_actions
```

## Class Name

`ThingSpaceQualityofServiceApiActionsApi`

## Methods

* [Create a Thing Space Quality of Service API Subscription](../../doc/controllers/thing-space-qualityof-service-api-actions.md#create-a-thing-space-quality-of-service-api-subscription)
* [Stop a Thing Space Quality of Service API Subscription](../../doc/controllers/thing-space-qualityof-service-api-actions.md#stop-a-thing-space-quality-of-service-api-subscription)


# Create a Thing Space Quality of Service API Subscription

Creates a QoS elevation subscription ID and activates the subscription.

```ruby
def create_a_thing_space_quality_of_service_api_subscription(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`SubscribeRequest`](../../doc/models/subscribe-request.md) | Body, Required | The request details to create a ThingSpace Quality of Service API subscription. |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`M201Success`](../../doc/models/m201-success.md).

## Example Usage

```ruby
body = SubscribeRequest.new(
  account_name: '0000123456-00001',
  device_info: [
    QosDeviceInfo.new(
      device_id: QosDeviceId.new(
        id: '10-digit phone number',
        kind: 'mdn'
      ),
      flow_info: [
        FlowInfo.new(
          flow_server: '[IPv6 address]:port',
          flow_device: '[IPv6 address]:port',
          flow_direction: 'UPLINK',
          flow_protocol: 'UDP',
          qci_option: 'Premium'
        )
      ],
      device_i_pv6_addr: 'IPv6 address'
    )
  ]
)

result = thing_space_quality_of_service_api_actions_api.create_a_thing_space_quality_of_service_api_subscription(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error Response | [`DefaultResponseException`](../../doc/models/default-response-exception.md) |


# Stop a Thing Space Quality of Service API Subscription

Stops an active ThingSpace Quality of Service API subscription using the account name and the subscription ID.

```ruby
def stop_a_thing_space_quality_of_service_api_subscription(account_name,
                                                           qos_subscription_id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Query, Required | - |
| `qos_subscription_id` | `String` | Query, Required | - |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`M201Success`](../../doc/models/m201-success.md).

## Example Usage

```ruby
account_name = '0000123456-00001'

qos_subscription_id = 'QoS subscription ID'

result = thing_space_quality_of_service_api_actions_api.stop_a_thing_space_quality_of_service_api_subscription(
  account_name,
  qos_subscription_id
)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error Response | [`DefaultResponseException`](../../doc/models/default-response-exception.md) |

