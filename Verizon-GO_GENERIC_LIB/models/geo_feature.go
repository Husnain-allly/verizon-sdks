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

// GeoFeature represents a GeoFeature struct.
type GeoFeature struct {
    Type       FeatureType `json:"type"`
    Geometry   interface{} `json:"geometry"`
    Properties interface{} `json:"properties"`
}

// String implements the fmt.Stringer interface for GeoFeature,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (g GeoFeature) String() string {
    return fmt.Sprintf(
    	"GeoFeature[Type=%v, Geometry=%v, Properties=%v]",
    	g.Type, g.Geometry, g.Properties)
}

// MarshalJSON implements the json.Marshaler interface for GeoFeature.
// It customizes the JSON marshaling process for GeoFeature objects.
func (g GeoFeature) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(g.toMap())
}

// toMap converts the GeoFeature object to a map representation for JSON marshaling.
func (g GeoFeature) toMap() map[string]any {
    structMap := make(map[string]any)
    structMap["type"] = g.Type
    structMap["geometry"] = g.Geometry
    structMap["properties"] = g.Properties
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for GeoFeature.
// It customizes the JSON unmarshaling process for GeoFeature objects.
func (g *GeoFeature) UnmarshalJSON(input []byte) error {
    var temp tempGeoFeature
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    err = temp.validate()
    if err != nil {
    	return err
    }
    
    g.Type = *temp.Type
    g.Geometry = *temp.Geometry
    g.Properties = *temp.Properties
    return nil
}

// tempGeoFeature is a temporary struct used for validating the fields of GeoFeature.
type tempGeoFeature  struct {
    Type       *FeatureType `json:"type"`
    Geometry   *interface{} `json:"geometry"`
    Properties *interface{} `json:"properties"`
}

func (g *tempGeoFeature) validate() error {
    var errs []string
    if g.Type == nil {
        errs = append(errs, "required field `type` is missing for type `GeoFeature`")
    }
    if g.Geometry == nil {
        errs = append(errs, "required field `geometry` is missing for type `GeoFeature`")
    }
    if g.Properties == nil {
        errs = append(errs, "required field `properties` is missing for type `GeoFeature`")
    }
    if len(errs) == 0 {
        return nil
    }
    return errors.New(strings.Join (errs, "\n"))
}
