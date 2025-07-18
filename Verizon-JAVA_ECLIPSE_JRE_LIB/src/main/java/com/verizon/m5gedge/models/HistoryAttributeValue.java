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
import com.fasterxml.jackson.databind.annotation.JsonDeserialize;
import com.fasterxml.jackson.databind.annotation.JsonSerialize;
import com.verizon.m5gedge.DateTimeHelper;
import io.apimatic.core.types.AdditionalProperties;
import io.apimatic.core.utilities.ConversionHelper;
import java.time.LocalDateTime;
import java.util.Map;

/**
 * This is a model class for HistoryAttributeValue type.
 */
public class HistoryAttributeValue {
    private AttributeIdentifier name;
    private String value;
    private LocalDateTime createdOn;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public HistoryAttributeValue() {
    }

    /**
     * Initialization constructor.
     * @param  name  AttributeIdentifier value for name.
     * @param  value  String value for value.
     * @param  createdOn  LocalDateTime value for createdOn.
     */
    public HistoryAttributeValue(
            AttributeIdentifier name,
            String value,
            LocalDateTime createdOn) {
        this.name = name;
        this.value = value;
        this.createdOn = createdOn;
    }

    /**
     * Getter for Name.
     * Attribute identifier.
     * @return Returns the AttributeIdentifier
     */
    @JsonGetter("name")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public AttributeIdentifier getName() {
        return name;
    }

    /**
     * Setter for Name.
     * Attribute identifier.
     * @param name Value for AttributeIdentifier
     */
    @JsonSetter("name")
    public void setName(AttributeIdentifier name) {
        this.name = name;
    }

    /**
     * Getter for Value.
     * Attribute value.
     * @return Returns the String
     */
    @JsonGetter("value")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getValue() {
        return value;
    }

    /**
     * Setter for Value.
     * Attribute value.
     * @param value Value for String
     */
    @JsonSetter("value")
    public void setValue(String value) {
        this.value = value;
    }

    /**
     * Getter for CreatedOn.
     * Date and time the request was created.
     * @return Returns the LocalDateTime
     */
    @JsonGetter("createdOn")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    @JsonSerialize(using = DateTimeHelper.Rfc8601DateTimeSerializer.class)
    public LocalDateTime getCreatedOn() {
        return createdOn;
    }

    /**
     * Setter for CreatedOn.
     * Date and time the request was created.
     * @param createdOn Value for LocalDateTime
     */
    @JsonSetter("createdOn")
    @JsonDeserialize(using = DateTimeHelper.Rfc8601DateTimeDeserializer.class)
    public void setCreatedOn(LocalDateTime createdOn) {
        this.createdOn = createdOn;
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
     * Converts this HistoryAttributeValue into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "HistoryAttributeValue [" + "name=" + name + ", value=" + value + ", createdOn="
                + createdOn + ", additionalProperties=" + additionalProperties + "]";
    }

    /**
     * Builds a new {@link HistoryAttributeValue.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link HistoryAttributeValue.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .name(getName())
                .value(getValue())
                .createdOn(getCreatedOn());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link HistoryAttributeValue}.
     */
    public static class Builder {
        private AttributeIdentifier name;
        private String value;
        private LocalDateTime createdOn;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for name.
         * @param  name  AttributeIdentifier value for name.
         * @return Builder
         */
        public Builder name(AttributeIdentifier name) {
            this.name = name;
            return this;
        }

        /**
         * Setter for value.
         * @param  value  String value for value.
         * @return Builder
         */
        public Builder value(String value) {
            this.value = value;
            return this;
        }

        /**
         * Setter for createdOn.
         * @param  createdOn  LocalDateTime value for createdOn.
         * @return Builder
         */
        public Builder createdOn(LocalDateTime createdOn) {
            this.createdOn = createdOn;
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
         * Builds a new {@link HistoryAttributeValue} object using the set fields.
         * @return {@link HistoryAttributeValue}
         */
        public HistoryAttributeValue build() {
            HistoryAttributeValue model =
                    new HistoryAttributeValue(name, value, createdOn);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
