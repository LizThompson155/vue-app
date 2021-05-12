import {Store,Module,ActionContext} from 'vuex'
import ListModule from './list-module'
import ListState from './list-state'
import Book from '../entities/book'
import Ajax from '../../lib/ajax'
import PageResult from '@/store/entities/page-result';
import ListMutations from './list-mutations'

interface BookState extends ListState<Book>{

}
class BookMutations extends ListMutations<Book>{

}
class BookModule extends ListModule<BookState, any, Book>{
    state={
        totalCount:0,
        currentPage:1,
        pageSize:10,
        list: new Array<Book>(),
        loading:false
    }
    actions={
        async getAll(context: ActionContext<BookState,any>,payload:any){
            context.state.loading=true;
            let reponse=await Ajax.get('/api/services/app/Books/GetBooks');
            context.state.loading=false;
            let page = reponse.data.result as PageResult<Book>;
            context.state.totalCount=page.totalCount;
            context.state.list=page.items;
        }
    };
    mutations={
        setCurrentPage(state: BookState,page:number){
            state.currentPage=page;
        },
        setPageSize(state: BookState,pagesize:number){
            state.pageSize=pagesize;
        }
    }
}
const bookModule=new BookModule();
export default bookModule;