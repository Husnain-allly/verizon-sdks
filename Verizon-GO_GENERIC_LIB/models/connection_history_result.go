/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// ConnectionHistoryResult represents a ConnectionHistoryResult struct.
// Response containing the connection history. It is a list of Network Connection Events for a device.
type ConnectionHistoryResult struct {
    // Device connection events, sorted by the occurredAt timestamp, oldest first.
    ConnectionHistory    []ConnectionEvent      `json:"connectionHistory,omitempty"`
    // False for a status 200 response.True for a status 202 response, indicating that there is more data to be retrieved. Send another request, adjusting the earliest value in the request based on the occuredAt value for the last device in the current response.
    HasMoreData          *bool                  `json:"hasMoreData,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for ConnectionHistoryResult,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (c ConnectionHistoryResult) String() string {
    return fmt.Sprintf(
    	"ConnectionHistoryResult[ConnectionHistory=%v, HasMoreData=%v, AdditionalProperties=%v]",
    	c.ConnectionHistory, c.HasMoreData, c.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for ConnectionHistoryResult.
// It customizes the JSON marshaling process for ConnectionHistoryResult objects.
func (c ConnectionHistoryResult) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(c.AdditionalProperties,
        "connectionHistory", "hasMoreData"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(c.toMap())
}

// toMap converts the ConnectionHistoryResult object to a map representation for JSON marshaling.
func (c ConnectionHistoryResult) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, c.AdditionalProperties)
    if c.ConnectionHistory != nil {
        structMap["connectionHistory"] = c.ConnectionHistory
    }
    if c.HasMoreData != nil {
        structMap["hasMoreData"] = c.HasMoreData
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for ConnectionHistoryResult.
// It customizes the JSON unmarshaling process for ConnectionHistoryResult objects.
func (c *ConnectionHistoryResult) UnmarshalJSON(input []byte) error {
    var temp tempConnectionHistoryResult
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "connectionHistory", "hasMoreData")
    if err != nil {
    	return err
    }
    c.AdditionalProperties = additionalProperties
    
    c.ConnectionHistory = temp.ConnectionHistory
    c.HasMoreData = temp.HasMoreData
    return nil
}

// tempConnectionHistoryResult is a temporary struct used for validating the fields of ConnectionHistoryResult.
type tempConnectionHistoryResult  struct {
    ConnectionHistory []ConnectionEvent `json:"connectionHistory,omitempty"`
    HasMoreData       *bool             `json:"hasMoreData,omitempty"`
}
