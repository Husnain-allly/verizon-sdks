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
import java.util.Map;

/**
 * This is a model class for Fields1 type.
 */
public class Fields1 {
    private SearchDeviceByPropertyFields item;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public Fields1() {
    }

    /**
     * Initialization constructor.
     * @param  item  SearchDeviceByPropertyFields value for item.
     */
    public Fields1(
            SearchDeviceByPropertyFields item) {
        this.item = item;
    }

    /**
     * Getter for Item.
     * List of device sensors and their most recently reported values.
     * @return Returns the SearchDeviceByPropertyFields
     */
    @JsonGetter("item")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public SearchDeviceByPropertyFields getItem() {
        return item;
    }

    /**
     * Setter for Item.
     * List of device sensors and their most recently reported values.
     * @param item Value for SearchDeviceByPropertyFields
     */
    @JsonSetter("item")
    public void setItem(SearchDeviceByPropertyFields item) {
        this.item = item;
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
     * Converts this Fields1 into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "Fields1 [" + "item=" + item + ", additionalProperties=" + additionalProperties
                + "]";
    }

    /**
     * Builds a new {@link Fields1.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link Fields1.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .item(getItem());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link Fields1}.
     */
    public static class Builder {
        private SearchDeviceByPropertyFields item;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for item.
         * @param  item  SearchDeviceByPropertyFields value for item.
         * @return Builder
         */
        public Builder item(SearchDeviceByPropertyFields item) {
            this.item = item;
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
         * Builds a new {@link Fields1} object using the set fields.
         * @return {@link Fields1}
         */
        public Fields1 build() {
            Fields1 model =
                    new Fields1(item);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
