<template>
    <div>
        <Card dis-hover>
            <div class="page-body">
                <Form ref="queryForm" :label-width="80" label-position="left" inline>
                    <Row :gutter="16">
                        <Col span="6">
                        <FormItem :label="L('Keyword')+':'" style="width:100%">
                        </FormItem>
                        </Col>
                        <Col span="6">
                        </Col>
                        <Col span="6">
                        <FormItem :label="L('CreationTime')+':'" style="width:100%">
                        </FormItem>
                        </Col>
                    </Row>
                    <Row>
                        <Button @click="create" icon="android-add" type="primary" size="large">{{L('Add')}}</Button>
                        <Button icon="ios-search" type="primary" size="large" @click="getpage" class="toolbar-btn">{{L('Find')}}</Button>
                    </Row>
                </Form>
                <div class="margin-top-10">
                    <Table :loading="loading" :columns="columns" :no-data-text="L('NoData')" border :data="list">
                    </Table>
                    <Page show-sizer class-name="fengpage" :total="totalCount" class="margin-top-10" @on-change="pageChange" @on-page-size-change="pagesizeChange" :page-size="pageSize" :current="currentPage"></Page>
                </div>
            </div>
        </Card>
       
    </div>
</template>
<script lang="ts">import { Component, Vue,Inject, Prop,Watch } from 'vue-property-decorator';
    import { Component, Vue, Inject, Prop, Watch } from 'vue-property-decorator';
    import Util from '../../../lib/util'
    import AbpBase from '../../lib/abpbase'
    import PageRequest from '@/store/entities/page-request'

    @Component
    export default class Books extends AbpBase {
        @Prop({ type: Boolean, default: false }) value: boolean;
        get list() {
            return this.$store.state.book.list;
        };
        get loading() {
            return this.$store.state.book.loading;
        }
        create() {
        }
        save() {
            
        }
        cancel() {
            
        }
        visibleChange(value: boolean) {
            
        }
        validatePassCheck = (rule: any, value: any, callback: any) => {
            
        };
    }</script>