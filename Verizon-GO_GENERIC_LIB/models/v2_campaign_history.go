/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "errors"
    "fmt"
    "strings"
)

// V2CampaignHistory represents a V2CampaignHistory struct.
// Campaign history details.
type V2CampaignHistory struct {
    // Has more report flag.
    HasMoreData          bool                   `json:"hasMoreData"`
    // Campaign identifier.
    LastSeenCampaignId   *string                `json:"lastSeenCampaignId,omitempty"`
    // Software upgrade list.
    CampaignList         []V2CampaignMetaInfo   `json:"campaignList"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for V2CampaignHistory,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (v V2CampaignHistory) String() string {
    return fmt.Sprintf(
    	"V2CampaignHistory[HasMoreData=%v, LastSeenCampaignId=%v, CampaignList=%v, AdditionalProperties=%v]",
    	v.HasMoreData, v.LastSeenCampaignId, v.CampaignList, v.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for V2CampaignHistory.
// It customizes the JSON marshaling process for V2CampaignHistory objects.
func (v V2CampaignHistory) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(v.AdditionalProperties,
        "hasMoreData", "lastSeenCampaignId", "campaignList"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(v.toMap())
}

// toMap converts the V2CampaignHistory object to a map representation for JSON marshaling.
func (v V2CampaignHistory) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, v.AdditionalProperties)
    structMap["hasMoreData"] = v.HasMoreData
    if v.LastSeenCampaignId != nil {
        structMap["lastSeenCampaignId"] = v.LastSeenCampaignId
    }
    if v.CampaignList != nil {
        structMap["campaignList"] = v.CampaignList
    } else {
        structMap["campaignList"] = nil
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for V2CampaignHistory.
// It customizes the JSON unmarshaling process for V2CampaignHistory objects.
func (v *V2CampaignHistory) UnmarshalJSON(input []byte) error {
    var temp tempV2CampaignHistory
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    err = temp.validate()
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "hasMoreData", "lastSeenCampaignId", "campaignList")
    if err != nil {
    	return err
    }
    v.AdditionalProperties = additionalProperties
    
    v.HasMoreData = *temp.HasMoreData
    v.LastSeenCampaignId = temp.LastSeenCampaignId
    v.CampaignList = temp.CampaignList
    return nil
}

// tempV2CampaignHistory is a temporary struct used for validating the fields of V2CampaignHistory.
type tempV2CampaignHistory  struct {
    HasMoreData        *bool                `json:"hasMoreData"`
    LastSeenCampaignId *string              `json:"lastSeenCampaignId,omitempty"`
    CampaignList       []V2CampaignMetaInfo `json:"campaignList"`
}

func (v *tempV2CampaignHistory) validate() error {
    var errs []string
    if v.HasMoreData == nil {
        errs = append(errs, "required field `hasMoreData` is missing for type `V2CampaignHistory`")
    }
    if len(errs) == 0 {
        return nil
    }
    return errors.New(strings.Join (errs, "\n"))
}
