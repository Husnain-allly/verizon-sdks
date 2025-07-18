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
 * This is a model class for SearchDeviceEventHistoryRequest type.
 */
public class SearchDeviceEventHistoryRequest {
    private AccountIdentifier accountidentifier;
    private Map<String, String> mSelection;
    private ResourceIdentifier resourceidentifier;
    private Integer mLimitnumber;
    private String mPage;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public SearchDeviceEventHistoryRequest() {
    }

    /**
     * Initialization constructor.
     * @param  accountidentifier  AccountIdentifier value for accountidentifier.
     * @param  resourceidentifier  ResourceIdentifier value for resourceidentifier.
     * @param  mSelection  Map of String, value for mSelection.
     * @param  mLimitnumber  Integer value for mLimitnumber.
     * @param  mPage  String value for mPage.
     */
    public SearchDeviceEventHistoryRequest(
            AccountIdentifier accountidentifier,
            ResourceIdentifier resourceidentifier,
            Map<String, String> mSelection,
            Integer mLimitnumber,
            String mPage) {
        this.accountidentifier = accountidentifier;
        this.mSelection = mSelection;
        this.resourceidentifier = resourceidentifier;
        this.mLimitnumber = mLimitnumber;
        this.mPage = mPage;
    }

    /**
     * Getter for Accountidentifier.
     * The ID of the authenticating billing account, in the format
     * `{"billingaccountid":"1234567890-12345"}`.
     * @return Returns the AccountIdentifier
     */
    @JsonGetter("accountidentifier")
    public AccountIdentifier getAccountidentifier() {
        return accountidentifier;
    }

    /**
     * Setter for Accountidentifier.
     * The ID of the authenticating billing account, in the format
     * `{"billingaccountid":"1234567890-12345"}`.
     * @param accountidentifier Value for AccountIdentifier
     */
    @JsonSetter("accountidentifier")
    public void setAccountidentifier(AccountIdentifier accountidentifier) {
        this.accountidentifier = accountidentifier;
    }

    /**
     * Getter for MSelection.
     * A comma-separated list of properties and comparator values to match against subscriptions in
     * the ThingSpace account. See Working with Query Filters for more information. If the request
     * does not include `$selection`, the response will include all subscriptions to which the
     * requesting user has access.
     * @return Returns the Map of String, String
     */
    @JsonGetter("$selection")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Map<String, String> getMSelection() {
        return mSelection;
    }

    /**
     * Setter for MSelection.
     * A comma-separated list of properties and comparator values to match against subscriptions in
     * the ThingSpace account. See Working with Query Filters for more information. If the request
     * does not include `$selection`, the response will include all subscriptions to which the
     * requesting user has access.
     * @param mSelection Value for Map of String, String
     */
    @JsonSetter("$selection")
    public void setMSelection(Map<String, String> mSelection) {
        this.mSelection = mSelection;
    }

    /**
     * Getter for Resourceidentifier.
     * The ID of the target to delete, in the format {"id": "dd1682d3-2d80-cefc-f3ee-25154800beff"}.
     * @return Returns the ResourceIdentifier
     */
    @JsonGetter("resourceidentifier")
    public ResourceIdentifier getResourceidentifier() {
        return resourceidentifier;
    }

    /**
     * Setter for Resourceidentifier.
     * The ID of the target to delete, in the format {"id": "dd1682d3-2d80-cefc-f3ee-25154800beff"}.
     * @param resourceidentifier Value for ResourceIdentifier
     */
    @JsonSetter("resourceidentifier")
    public void setResourceidentifier(ResourceIdentifier resourceidentifier) {
        this.resourceidentifier = resourceidentifier;
    }

    /**
     * Getter for MLimitnumber.
     * The maximum number of events to include in the response.
     * @return Returns the Integer
     */
    @JsonGetter("$limitnumber")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Integer getMLimitnumber() {
        return mLimitnumber;
    }

    /**
     * Setter for MLimitnumber.
     * The maximum number of events to include in the response.
     * @param mLimitnumber Value for Integer
     */
    @JsonSetter("$limitnumber")
    public void setMLimitnumber(Integer mLimitnumber) {
        this.mLimitnumber = mLimitnumber;
    }

    /**
     * Getter for MPage.
     * The maximum number of events to include in the response.
     * @return Returns the String
     */
    @JsonGetter("$page")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getMPage() {
        return mPage;
    }

    /**
     * Setter for MPage.
     * The maximum number of events to include in the response.
     * @param mPage Value for String
     */
    @JsonSetter("$page")
    public void setMPage(String mPage) {
        this.mPage = mPage;
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
     * Converts this SearchDeviceEventHistoryRequest into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "SearchDeviceEventHistoryRequest [" + "accountidentifier=" + accountidentifier
                + ", resourceidentifier=" + resourceidentifier + ", mSelection=" + mSelection
                + ", mLimitnumber=" + mLimitnumber + ", mPage=" + mPage + ", additionalProperties="
                + additionalProperties + "]";
    }

    /**
     * Builds a new {@link SearchDeviceEventHistoryRequest.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link SearchDeviceEventHistoryRequest.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(accountidentifier, resourceidentifier)
                .mSelection(getMSelection())
                .mLimitnumber(getMLimitnumber())
                .mPage(getMPage());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link SearchDeviceEventHistoryRequest}.
     */
    public static class Builder {
        private AccountIdentifier accountidentifier;
        private ResourceIdentifier resourceidentifier;
        private Map<String, String> mSelection;
        private Integer mLimitnumber;
        private String mPage;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  accountidentifier  AccountIdentifier value for accountidentifier.
         * @param  resourceidentifier  ResourceIdentifier value for resourceidentifier.
         */
        public Builder(AccountIdentifier accountidentifier, ResourceIdentifier resourceidentifier) {
            this.accountidentifier = accountidentifier;
            this.resourceidentifier = resourceidentifier;
        }

        /**
         * Setter for accountidentifier.
         * @param  accountidentifier  AccountIdentifier value for accountidentifier.
         * @return Builder
         */
        public Builder accountidentifier(AccountIdentifier accountidentifier) {
            this.accountidentifier = accountidentifier;
            return this;
        }

        /**
         * Setter for resourceidentifier.
         * @param  resourceidentifier  ResourceIdentifier value for resourceidentifier.
         * @return Builder
         */
        public Builder resourceidentifier(ResourceIdentifier resourceidentifier) {
            this.resourceidentifier = resourceidentifier;
            return this;
        }

        /**
         * Setter for mSelection.
         * @param  mSelection  Map of String, value for mSelection.
         * @return Builder
         */
        public Builder mSelection(Map<String, String> mSelection) {
            this.mSelection = mSelection;
            return this;
        }

        /**
         * Setter for mLimitnumber.
         * @param  mLimitnumber  Integer value for mLimitnumber.
         * @return Builder
         */
        public Builder mLimitnumber(Integer mLimitnumber) {
            this.mLimitnumber = mLimitnumber;
            return this;
        }

        /**
         * Setter for mPage.
         * @param  mPage  String value for mPage.
         * @return Builder
         */
        public Builder mPage(String mPage) {
            this.mPage = mPage;
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
         * Builds a new {@link SearchDeviceEventHistoryRequest} object using the set fields.
         * @return {@link SearchDeviceEventHistoryRequest}
         */
        public SearchDeviceEventHistoryRequest build() {
            SearchDeviceEventHistoryRequest model =
                    new SearchDeviceEventHistoryRequest(accountidentifier, resourceidentifier,
                            mSelection, mLimitnumber, mPage);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
