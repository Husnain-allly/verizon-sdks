/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonSetter;

/**
 * This is a model class for DtoListUserRequest type.
 */
public class DtoListUserRequest {
    private String accountname;
    private DtoFilter filter;

    /**
     * Default constructor.
     */
    public DtoListUserRequest() {
    }

    /**
     * Initialization constructor.
     * @param  accountname  String value for accountname.
     * @param  filter  DtoFilter value for filter.
     */
    public DtoListUserRequest(
            String accountname,
            DtoFilter filter) {
        this.accountname = accountname;
        this.filter = filter;
    }

    /**
     * Getter for Accountname.
     * The numeric account name, which must include leading zeros
     * @return Returns the String
     */
    @JsonGetter("accountname")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getAccountname() {
        return accountname;
    }

    /**
     * Setter for Accountname.
     * The numeric account name, which must include leading zeros
     * @param accountname Value for String
     */
    @JsonSetter("accountname")
    public void setAccountname(String accountname) {
        this.accountname = accountname;
    }

    /**
     * Getter for Filter.
     * @return Returns the DtoFilter
     */
    @JsonGetter("filter")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public DtoFilter getFilter() {
        return filter;
    }

    /**
     * Setter for Filter.
     * @param filter Value for DtoFilter
     */
    @JsonSetter("filter")
    public void setFilter(DtoFilter filter) {
        this.filter = filter;
    }

    /**
     * Converts this DtoListUserRequest into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "DtoListUserRequest [" + "accountname=" + accountname + ", filter=" + filter + "]";
    }

    /**
     * Builds a new {@link DtoListUserRequest.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link DtoListUserRequest.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .accountname(getAccountname())
                .filter(getFilter());
        return builder;
    }

    /**
     * Class to build instances of {@link DtoListUserRequest}.
     */
    public static class Builder {
        private String accountname;
        private DtoFilter filter;



        /**
         * Setter for accountname.
         * @param  accountname  String value for accountname.
         * @return Builder
         */
        public Builder accountname(String accountname) {
            this.accountname = accountname;
            return this;
        }

        /**
         * Setter for filter.
         * @param  filter  DtoFilter value for filter.
         * @return Builder
         */
        public Builder filter(DtoFilter filter) {
            this.filter = filter;
            return this;
        }

        /**
         * Builds a new {@link DtoListUserRequest} object using the set fields.
         * @return {@link DtoListUserRequest}
         */
        public DtoListUserRequest build() {
            return new DtoListUserRequest(accountname, filter);
        }
    }
}
