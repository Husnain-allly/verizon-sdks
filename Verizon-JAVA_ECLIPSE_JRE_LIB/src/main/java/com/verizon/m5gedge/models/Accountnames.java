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
 * This is a model class for Accountnames type.
 */
public class Accountnames {
    private List<String> accountNameList;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public Accountnames() {
    }

    /**
     * Initialization constructor.
     * @param  accountNameList  List of String value for accountNameList.
     */
    public Accountnames(
            List<String> accountNameList) {
        this.accountNameList = accountNameList;
    }

    /**
     * Getter for AccountNameList.
     * @return Returns the List of String
     */
    @JsonGetter("accountNameList")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<String> getAccountNameList() {
        return accountNameList;
    }

    /**
     * Setter for AccountNameList.
     * @param accountNameList Value for List of String
     */
    @JsonSetter("accountNameList")
    public void setAccountNameList(List<String> accountNameList) {
        this.accountNameList = accountNameList;
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
     * Converts this Accountnames into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "Accountnames [" + "accountNameList=" + accountNameList + ", additionalProperties="
                + additionalProperties + "]";
    }

    /**
     * Builds a new {@link Accountnames.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link Accountnames.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .accountNameList(getAccountNameList());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link Accountnames}.
     */
    public static class Builder {
        private List<String> accountNameList;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for accountNameList.
         * @param  accountNameList  List of String value for accountNameList.
         * @return Builder
         */
        public Builder accountNameList(List<String> accountNameList) {
            this.accountNameList = accountNameList;
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
         * Builds a new {@link Accountnames} object using the set fields.
         * @return {@link Accountnames}
         */
        public Accountnames build() {
            Accountnames model =
                    new Accountnames(accountNameList);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
