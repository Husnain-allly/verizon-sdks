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
 * This is a model class for ConnectionEvent type.
 */
public class ConnectionEvent {
    private List<CustomFields> connectionEventAttributes;
    private List<CustomFields> extendedAttributes;
    private String occurredAt;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public ConnectionEvent() {
    }

    /**
     * Initialization constructor.
     * @param  connectionEventAttributes  List of CustomFields value for connectionEventAttributes.
     * @param  extendedAttributes  List of CustomFields value for extendedAttributes.
     * @param  occurredAt  String value for occurredAt.
     */
    public ConnectionEvent(
            List<CustomFields> connectionEventAttributes,
            List<CustomFields> extendedAttributes,
            String occurredAt) {
        this.connectionEventAttributes = connectionEventAttributes;
        this.extendedAttributes = extendedAttributes;
        this.occurredAt = occurredAt;
    }

    /**
     * Getter for ConnectionEventAttributes.
     * The attributes that describe the connection event.
     * @return Returns the List of CustomFields
     */
    @JsonGetter("connectionEventAttributes")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<CustomFields> getConnectionEventAttributes() {
        return connectionEventAttributes;
    }

    /**
     * Setter for ConnectionEventAttributes.
     * The attributes that describe the connection event.
     * @param connectionEventAttributes Value for List of CustomFields
     */
    @JsonSetter("connectionEventAttributes")
    public void setConnectionEventAttributes(List<CustomFields> connectionEventAttributes) {
        this.connectionEventAttributes = connectionEventAttributes;
    }

    /**
     * Getter for ExtendedAttributes.
     * Currently not used.
     * @return Returns the List of CustomFields
     */
    @JsonGetter("extendedAttributes")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<CustomFields> getExtendedAttributes() {
        return extendedAttributes;
    }

    /**
     * Setter for ExtendedAttributes.
     * Currently not used.
     * @param extendedAttributes Value for List of CustomFields
     */
    @JsonSetter("extendedAttributes")
    public void setExtendedAttributes(List<CustomFields> extendedAttributes) {
        this.extendedAttributes = extendedAttributes;
    }

    /**
     * Getter for OccurredAt.
     * The date and time when the connection event occured.
     * @return Returns the String
     */
    @JsonGetter("occurredAt")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getOccurredAt() {
        return occurredAt;
    }

    /**
     * Setter for OccurredAt.
     * The date and time when the connection event occured.
     * @param occurredAt Value for String
     */
    @JsonSetter("occurredAt")
    public void setOccurredAt(String occurredAt) {
        this.occurredAt = occurredAt;
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
     * Converts this ConnectionEvent into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "ConnectionEvent [" + "connectionEventAttributes=" + connectionEventAttributes
                + ", extendedAttributes=" + extendedAttributes + ", occurredAt=" + occurredAt
                + ", additionalProperties=" + additionalProperties + "]";
    }

    /**
     * Builds a new {@link ConnectionEvent.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link ConnectionEvent.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .connectionEventAttributes(getConnectionEventAttributes())
                .extendedAttributes(getExtendedAttributes())
                .occurredAt(getOccurredAt());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link ConnectionEvent}.
     */
    public static class Builder {
        private List<CustomFields> connectionEventAttributes;
        private List<CustomFields> extendedAttributes;
        private String occurredAt;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for connectionEventAttributes.
         * @param  connectionEventAttributes  List of CustomFields value for
         *         connectionEventAttributes.
         * @return Builder
         */
        public Builder connectionEventAttributes(List<CustomFields> connectionEventAttributes) {
            this.connectionEventAttributes = connectionEventAttributes;
            return this;
        }

        /**
         * Setter for extendedAttributes.
         * @param  extendedAttributes  List of CustomFields value for extendedAttributes.
         * @return Builder
         */
        public Builder extendedAttributes(List<CustomFields> extendedAttributes) {
            this.extendedAttributes = extendedAttributes;
            return this;
        }

        /**
         * Setter for occurredAt.
         * @param  occurredAt  String value for occurredAt.
         * @return Builder
         */
        public Builder occurredAt(String occurredAt) {
            this.occurredAt = occurredAt;
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
         * Builds a new {@link ConnectionEvent} object using the set fields.
         * @return {@link ConnectionEvent}
         */
        public ConnectionEvent build() {
            ConnectionEvent model =
                    new ConnectionEvent(connectionEventAttributes, extendedAttributes, occurredAt);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
