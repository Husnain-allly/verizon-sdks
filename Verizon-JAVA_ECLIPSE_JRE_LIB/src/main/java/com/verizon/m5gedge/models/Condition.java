/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;

import com.fasterxml.jackson.annotation.JsonAnyGetter;
import com.fasterxml.jackson.annotation.JsonAnySetter;
import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonSetter;
import io.apimatic.core.types.AdditionalProperties;
import io.apimatic.core.utilities.ConversionHelper;
import java.util.List;
import java.util.Map;

/**
 * This is a model class for Condition type.
 */
public class Condition {
    private List<Keyschunk2> condition;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public Condition() {
    }

    /**
     * Initialization constructor.
     * @param  condition  List of Keyschunk2 value for condition.
     */
    public Condition(
            List<Keyschunk2> condition) {
        this.condition = condition;
    }

    /**
     * Getter for Condition.
     * @return Returns the List of Keyschunk2
     */
    @JsonGetter("condition")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<Keyschunk2> getCondition() {
        return condition;
    }

    /**
     * Setter for Condition.
     * @param condition Value for List of Keyschunk2
     */
    @JsonSetter("condition")
    public void setCondition(List<Keyschunk2> condition) {
        this.condition = condition;
    }

    /**
     * Hidden method for the serialization of additional properties.
     * @return The map of additionally set properties.
     */
    @JsonAnyGetter
    private Map<String, Object> getAdditionalProperties() {
        return additionalProperties.getAdditionalProperties();
    }

    /**
     * Hidden method for the de-serialization of additional properties.
     * @param name The name of the additional property.
     * @param value The Object value of the additional property.
     */
    @JsonAnySetter
    private void setAdditionalProperties(String name, Object value) {
        additionalProperties.setAdditionalProperty(name,
                ConversionHelper.convertToSimpleType(value,
                        x -> x),
                true);
    }

    /**
     * Getter for the value of additional properties based on provided property name.
     * @param name The name of the additional property.
     * @return Either the Object property value or null if not exist.
     */
    
    public Object getAdditionalProperty(String name) {
        return additionalProperties.getAdditionalProperty(name);
    }

    /**
     * Converts this Condition into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "Condition [" + "condition=" + condition + ", additionalProperties="
                + additionalProperties + "]";
    }

    /**
     * Builds a new {@link Condition.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link Condition.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .condition(getCondition());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link Condition}.
     */
    public static class Builder {
        private List<Keyschunk2> condition;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for condition.
         * @param  condition  List of Keyschunk2 value for condition.
         * @return Builder
         */
        public Builder condition(List<Keyschunk2> condition) {
            this.condition = condition;
            return this;
        }

        /**
         * Setter for additional property that are not in model fields.
         * @param name The name of the additional property.
         * @param value The Object value of the additional property.
         * @return Builder.
         */
        public Builder additionalProperty(String name, Object value) {
            this.additionalProperties.setAdditionalProperty(name, value);
            return this;
        }

        /**
         * Builds a new {@link Condition} object using the set fields.
         * @return {@link Condition}
         */
        public Condition build() {
            Condition model =
                    new Condition(condition);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
